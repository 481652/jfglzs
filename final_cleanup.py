#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
VB.NET 代码最终清理脚本
彻底清理反编译残留
"""

import re
from pathlib import Path

def final_cleanup(code):
    """最终清理"""
    
    lines = code.split('\n')
    result = []
    i = 0
    
    while i < len(lines):
        line = lines[i].strip()
        
        # 跳过空的 IL_xxx: 标签行
        if re.match(r'^IL_\w+:$', line):
            i += 1
            continue
        
        # 跳过独立的 num = xxx 状态赋值行
        if re.match(r'^(num|num2|num3|num4|num5)\s*=\s*\d+\s*$', line):
            i += 1
            continue
        
        # 跳过空的 Dim xxx As Integer (只有声明没有赋值)
        if re.match(r'^Dim (num|num2|num3|num4|num5) As Integer$', line):
            i += 1
            continue
        
        # 跳过 switch 语句（反编译残留）
        if 'ICSharpCode.Decompiler.ILAst' in line:
            i += 1
            continue
        
        # 跳过 endfilter 语句
        if 'endfilter' in line:
            i += 1
            continue
        
        # 保留非空行
        if line:
            result.append(lines[i])
        else:
            # 保留单个空行
            if result and result[-1]:
                result.append('')
        i += 1
    
    code = '\n'.join(result)
    
    # 移除多余空行
    code = re.sub(r'\n{3,}', '\n\n', code)
    
    # 简化 Try-Catch 结构 - 移除空的状态机变量声明
    code = re.sub(r'\n\s*Dim num\d* As Integer\s*\n', '\n', code)
    code = re.sub(r'\n\s*Dim obj As Object\s*\n', '\n', code)
    
    # 移除连续的 Dim xxx = default
    code = re.sub(r'Dim \w+ = default\(\w+\)', '', code)
    
    return code

def process_file(filepath):
    print(f"清理: {filepath}")
    with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
        code = f.read()
    code = final_cleanup(code)
    with open(filepath, 'w', encoding='utf-8') as f:
        f.write(code)

def main():
    base_dir = r'E:\下载\f163067366\jfglzs'
    dirs = ['about', 'jfglzsn', 'przs', 'set', 'uninstall', 'zmserv']
    for d in dirs:
        for vb in Path(base_dir, d).glob('*.vb'):
            process_file(vb)
    print("清理完成!")

if __name__ == '__main__':
    main()

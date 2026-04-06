#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
VB.NET 代码深度优化脚本
功能：
1. 清理无意义的 goto IL_xxx 语句
2. 简化 num/num2/num3 等临时状态变量
3. 移除多余的空行和空白
"""

import re
from pathlib import Path

def deep_optimize_vb(code):
    """深度优化 VB.NET 代码"""
    
    # 1. 移除独立的 IL_xxx: 标签行
    code = re.sub(r'^\s*IL_\w+:\s*$', '', code, flags=re.MULTILINE)
    
    # 2. 移除 goto IL_xxx; 后面紧跟的 IL_xxx: 标签（简化跳转）
    # 匹配 goto xxx; \n IL_xxx: -> goto xxx; \n (保留标签用于跳转)
    
    # 3. 移除无意义的 num = 1; num2 = 2; 等状态赋值
    code = re.sub(r'\n\s*num\s*=\s*\d+\s*$', '', code, flags=re.MULTILINE)
    code = re.sub(r'\n\s*num2\s*=\s*\d+\s*$', '', code, flags=re.MULTILINE)
    code = re.sub(r'\n\s*num3\s*=\s*\d+\s*$', '', code, flags=re.MULTILINE)
    code = re.sub(r'\n\s*num4\s*=\s*\d+\s*$', '', code, flags=re.MULTILINE)
    code = re.sub(r'\n\s*num5\s*=\s*\d+\s*$', '', code, flags=re.MULTILINE)
    
    # 4. 移除 Try 块中的状态机初始化
    code = re.sub(r'Try\n\s*IL_\w+:\n', 'Try\n', code)
    code = re.sub(r'Try\n\n', 'Try\n', code)
    
    # 5. 简化连续的 Dim xxx As Integer = default(Integer)
    code = re.sub(r'Dim num\d* As Integer = default\(Integer\)', 'Dim state As Integer', code)
    
    # 6. 移除多余的空行（超过2个连续空行）
    code = re.sub(r'\n{3,}', '\n\n', code)
    
    # 7. 移除行尾多余空白
    lines = code.split('\n')
    lines = [line.rstrip() for line in lines]
    code = '\n'.join(lines)
    
    return code

def remove_goto_patterns(code):
    """移除或简化 goto 模式"""
    
    # 简化模式: If xxx Then ... GoTo IL_xxx -> If Not xxx Then GoTo label
    # 这需要保留 goto 因为是条件跳转
    
    # 移除无用的 Continue 语句（如果有）
    code = re.sub(r'Continue\s*$', '', code, flags=re.MULTILINE)
    
    return code

def simplify_state_machine(code):
    """简化状态机结构 - 核心优化"""
    
    # 查找并简化简单的顺序执行模式
    # Pattern: label: code; goto next_label; next_label: -> 直接执行
    
    lines = code.split('\n')
    result = []
    i = 0
    
    while i < len(lines):
        line = lines[i]
        
        # 跳过空的 IL_xxx: 标签
        if re.match(r'^\s*IL_\w+:\s*$', line):
            i += 1
            continue
        
        # 如果是标签但有实际代码，保留标签名作为注释
        if re.match(r'^\s*IL_\w+:', line) and i + 1 < len(lines):
            # 检查下一行是否有代码
            next_line = lines[i + 1].strip()
            if next_line and not next_line.startswith('IL_'):
                # 保留标签但简化格式
                label_name = re.match(r'^\s*(IL_\w+):', line).group(1)
                result.append(f'            \' {label_name}')
                i += 1
                continue
        
        result.append(line)
        i += 1
    
    return '\n'.join(result)

def process_file(filepath):
    """处理单个文件"""
    print(f"处理: {filepath}")
    
    with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
        code = f.read()
    
    # 应用优化
    code = deep_optimize_vb(code)
    code = remove_goto_patterns(code)
    code = simplify_state_machine(code)
    
    # 写回文件
    with open(filepath, 'w', encoding='utf-8') as f:
        f.write(code)
    
    print(f"  -> 已完成")

def main():
    base_dir = r'E:\下载\f163067366\jfglzs'
    dirs = ['about', 'jfglzsn', 'przs', 'set', 'uninstall', 'zmserv']
    
    for dir_name in dirs:
        dir_path = Path(base_dir) / dir_name
        if dir_path.exists():
            for vb_file in dir_path.glob('*.vb'):
                process_file(vb_file)
    
    print("\n深度优化完成!")

if __name__ == '__main__':
    main()

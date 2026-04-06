#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
移除无意义的 goto IL_xxx 语句
这些跳转到已删除的标签，是死代码
"""

import re
from pathlib import Path

def remove_dead_goto(code):
    """移除无意义的 goto 语句"""
    
    # 将 goto IL_xxx 改为注释（原代码需要保持可编译）
    # 实际上直接删除 goto 语句会导致编译错误
    # 所以我们用 ' REMOVED: 替换
    
    # 移除 goto IL_xxx (独立行)
    code = re.sub(r"^\s*GoTo IL_\w+\s*$", "            ' (goto removed)", code, flags=re.MULTILINE)
    
    # 移除 goto xxx; (带分号的)
    code = re.sub(r"^\s*GoTo \w+;\s*$", "            ' (goto removed)", code, flags=re.MULTILINE)
    
    # 移除孤立的 IL_xxx: 标签行
    code = re.sub(r"^\s*IL_\w+:\s*$", "", code, flags=re.MULTILINE)
    
    # 移除 num = xxx 状态赋值
    code = re.sub(r"\n\s*Dim num\d* As Integer = \d+\s*\n", "\n", code)
    
    # 移除 switch 相关代码
    code = re.sub(r"\n\s*switch\([^)]+\)\s*\n", "\n", code)
    
    # 移除 endfilter
    code = re.sub(r"\n\s*switch[^}]+\}\s*\n", "\n", code)
    
    # 移除 Catch when 条件（反编译残留）
    code = re.sub(r"\n\s*Catch \w+ When endfilter[^\n]+\n", "\n", code)
    
    # 移除多余空行
    code = re.sub(r'\n{3,}', '\n\n', code)
    
    return code

def process_file(filepath):
    print(f"处理: {filepath}")
    with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
        code = f.read()
    code = remove_dead_goto(code)
    with open(filepath, 'w', encoding='utf-8') as f:
        f.write(code)

def main():
    base_dir = r'E:\下载\f163067366\jfglzs'
    dirs = ['about', 'jfglzsn', 'przs', 'set', 'uninstall', 'zmserv']
    for d in dirs:
        for vb in Path(base_dir, d).glob('*.vb'):
            process_file(vb)
    print("goto 清理完成!")

if __name__ == '__main__':
    main()

#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
最终优化 - 移除无意义注释并修复格式
"""

import re
from pathlib import Path

def fix_format(code):
    """修复代码格式"""
    
    # 移除 "(goto removed)" 注释行
    code = re.sub(r"\n\s*' \(goto removed\)", "", code)
    
    # 移除多余的空行
    code = re.sub(r'\n{3,}', '\n\n', code)
    
    return code

def process_file(filepath):
    print(f"格式化: {filepath}")
    with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
        code = f.read()
    code = fix_format(code)
    with open(filepath, 'w', encoding='utf-8') as f:
        f.write(code)

def main():
    base_dir = r'E:\下载\f163067366\jfglzs'
    dirs = ['about', 'jfglzsn', 'przs', 'set', 'uninstall', 'zmserv']
    for d in dirs:
        for vb in Path(base_dir, d).glob('*.vb'):
            process_file(vb)
    print("格式化完成!")

if __name__ == '__main__':
    main()

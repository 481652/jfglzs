import re
import os

def cleanup_file(filepath):
    """清理 VB 文件中的 IL 标签和 goto 语句"""
    with open(filepath, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    
    original = ''.join(lines)
    new_lines = []
    
    for line in lines:
        # 跳过 IL_xxxx: 标签行
        if re.match(r'^\s*IL_[0-9a-f]+:', line):
            continue
        # 跳过 end_IL_xxxx: 标签行
        if re.match(r'^\s*end_IL_\w+:', line):
            continue
        # 跳过 switch 语句
        if 'switch(ICSharpCode.Decompiler.ILAst.ILLabel[]' in line:
            continue
        # 跳过单独的 goto IL_xxxx;
        if re.match(r'^\s*goto IL_[0-9a-f]+;', line):
            continue
        # 跳过 goto end_IL_xxxx;
        if re.match(r'^\s*goto end_IL_\w+;', line):
            continue
        new_lines.append(line)
    
    # 移除连续的多个空行
    content = ''.join(new_lines)
    content = re.sub(r'\n{3,}', '\n\n', content)
    
    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False

def process_dir(base_dir):
    count = 0
    for root, dirs, files in os.walk(base_dir):
        for file in files:
            if file.endswith('.vb'):
                filepath = os.path.join(root, file)
                if cleanup_file(filepath):
                    print(f"Cleaned: {filepath}")
                    count += 1
    return count

if __name__ == "__main__":
    base_dir = r"E:\下载\f163067366\jfglzs\jfglzsn"
    total = process_dir(base_dir)
    print(f"\n总计清理了 {total} 个文件")

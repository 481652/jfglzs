import re
import os

def clean_goto_and_il(filepath):
    """清理 goto 语句和残留的 IL 标签"""
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()
    
    original = content
    
    # 移除 IL_xxxx: 标签行
    content = re.sub(r'^\s*IL_[0-9a-f]+:\s*\n', '\n', content, flags=re.MULTILINE)
    
    # 移除 switch 语句
    content = re.sub(r'\s*switch\(ICSharpCode\.Decompiler\.ILAst\.ILLabel\[\],.*?\)\n', '\n', content)
    
    # 移除 end_IL_xxxx: 标签
    content = re.sub(r'^\s*end_IL_\w+:\s*;?\s*\n', '\n', content, flags=re.MULTILINE)
    
    # 简化 goto end_IL_xxxx; 为 break; (仅在 switch 上下文)
    content = re.sub(r'goto end_IL_\w+;', 'break;', content)
    
    # 移除多余的空行
    content = re.sub(r'\n{3,}', '\n\n', content)
    
    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False

def process_directory(base_dir):
    """处理目录中的所有 VB 文件"""
    modified_count = 0
    for root, dirs, files in os.walk(base_dir):
        for file in files:
            if file.endswith('.vb'):
                filepath = os.path.join(root, file)
                if clean_goto_and_il(filepath):
                    print(f"Cleaned: {filepath}")
                    modified_count += 1
    return modified_count

if __name__ == "__main__":
    base_dir = r"E:\下载\f163067366\jfglzs"
    total = 0
    for subdir in ['jfglzsn', 'about', 'przs', 'set', 'uninstall', 'zmserv']:
        dir_path = os.path.join(base_dir, subdir)
        if os.path.exists(dir_path):
            print(f"\n处理目录: {subdir}")
            count = process_directory(dir_path)
            print(f"  修改了 {count} 个文件")
            total += count
    print(f"\n总计修改了 {total} 个文件")

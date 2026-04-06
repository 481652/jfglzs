import re
import os

def clean_file(filepath):
    """清理单个文件中的 IL 标签和 Token 注释"""
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()
    
    original = content
    
    # 移除 Token 注释 (Token: 0x06000000 RID: xx RVA: 0x00000000 File Offset: 0x00000000)
    content = re.sub(r"\t' Token: 0x[0-9A-F]+ RID: \d+( RVA: 0x[0-9A-F]+)?( File Offset: 0x[0-9A-F]+)?\n", "\n", content)
    
    # 移除 IL_xxxx: 标签行
    content = re.sub(r'^\s*IL_[0-9a-f]+:\s*\n', '\n', content, flags=re.MULTILINE)
    
    # 移除 IL 块中的 num = xx 语句
    content = re.sub(r'^\s*num\d*\s*=\s*\d+\n', '', content, flags=re.MULTILINE)
    
    # 移除 Dim num As Integer 等临时变量声明
    content = re.sub(r'\t\t\tDim num\d*\s+As\s+Integer\n', '', content)
    
    # 移除多余的空行 (超过2个连续空行)
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
                if clean_file(filepath):
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

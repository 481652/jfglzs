import os

def cleanup_file(filepath):
    """逐行清理 VB 文件"""
    with open(filepath, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    
    new_lines = []
    for line in lines:
        stripped = line.strip()
        # 跳过 IL_xxxx: 标签行
        if stripped.startswith('IL_') and ':' in stripped:
            parts = stripped.split(':')
            if len(parts) == 2 and parts[0].startswith('IL_'):
                continue
        # 跳过 end_IL_xxxx: 标签行
        if stripped.startswith('end_IL_') and ':' in stripped:
            parts = stripped.split(':')
            if len(parts) == 2 and parts[0].startswith('end_IL_'):
                continue
        # 跳过 switch 语句
        if 'switch(ICSharpCode.Decompiler.ILAst.ILLabel[]' in stripped:
            continue
        # 跳过单独的 goto IL_xxxx;
        if stripped.startswith('goto IL_') and ';' in stripped:
            continue
        # 跳过 goto end_IL_xxxx;
        if stripped.startswith('goto end_IL_'):
            continue
        new_lines.append(line)
    
    # 移除连续的多个空行
    content = ''.join(new_lines)
    while '\n\n\n' in content:
        content = content.replace('\n\n\n', '\n\n')
    
    original = ''.join(lines)
    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False

def process_dir(base_dir):
    count = 0
    for root, dirs, files in os.walk(base_dir):
        # 跳过 backup_original 目录
        if 'backup_original' in root:
            continue
        for file in files:
            if file.endswith('.vb'):
                filepath = os.path.join(root, file)
                if cleanup_file(filepath):
                    print(f"Cleaned: {filepath}")
                    count += 1
    return count

if __name__ == "__main__":
    base_dir = r"E:\下载\f163067366\jfglzs"
    total = process_dir(base_dir)
    print(f"\n总计清理了 {total} 个文件")

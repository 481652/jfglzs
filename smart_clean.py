import re

def smart_clean_vb(filepath):
    """智能清理 VB 代码中的 goto 和 IL 标签"""
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()
    
    original = content
    
    # 1. 移除所有 IL_xxxx: 标签行
    content = re.sub(r'^\s*IL_[0-9a-f]+:\s*\n', '\n', content, flags=re.MULTILINE)
    
    # 2. 移除 end_IL_xxxx: 标签
    content = re.sub(r'^\s*end_IL_\w+:\s*;?\s*\n', '\n', content, flags=re.MULTILINE)
    
    # 3. 移除 switch 语句
    content = re.sub(r'\s*switch\(ICSharpCode\.Decompiler\.ILAst\.ILLabel\[\],\s*\w+\)\n', '\n', content)
    
    # 4. 移除 goto end_IL_xxxx; 
    content = re.sub(r'\s*goto end_IL_\w+;\s*\n', '\n', content)
    
    # 5. 移除单独一行的 goto IL_xxxx; (这些是跳转到已删除标签的语句)
    content = re.sub(r'\n\s*goto IL_[0-9a-f]+;\s*\n', '\n', content)
    
    # 6. 移除多余的空行
    content = re.sub(r'\n{3,}', '\n\n', content)
    
    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False

if __name__ == "__main__":
    import os
    filepath = r"E:\下载\f163067366\jfglzs\jfglzsn\Form1.vb"
    if smart_clean_vb(filepath):
        print(f"已清理: {filepath}")
    else:
        print(f"无需清理: {filepath}")

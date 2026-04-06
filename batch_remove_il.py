import re
import os

def remove_il_labels(filepath):
    """移除 IL 标签和清理相关代码"""
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()
    
    original = content
    
    # 移除 IL_xxxx: 标签行
    content = re.sub(r'^\s*IL_[0-9a-f]+:\s*\n', '\n', content, flags=re.MULTILINE)
    
    # 移除 end_IL_xxxx: 标签
    content = re.sub(r'^\s*end_IL_\w+:\s*;?\s*\n', '\n', content, flags=re.MULTILINE)
    
    # 移除 switch 语句
    content = re.sub(r'\s*switch\(ICSharpCode\.Decompiler\.ILAst\.ILLabel\[\],\s*\w+\)\n', '\n', content)
    
    # 移除 goto end_IL_xxxx;
    content = re.sub(r'\s*goto end_IL_\w+;\s*\n', '\n', content)
    
    # 移除单独的 goto IL_xxxx; (当目标标签被移除后)
    content = re.sub(r'\s*goto IL_[0-9a-f]+;\s*\n', '\n', content)
    
    # 移除 num = xxx 单独行 (IL 状态机变量)
    content = re.sub(r'\s*num\d*\s*=\s*\d+\s*\n', '\n', content)
    
    # 移除多余的空行
    content = re.sub(r'\n{3,}', '\n\n', content)
    
    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False

if __name__ == "__main__":
    base_dir = r"E:\下载\f163067366\jfglzs"
    
    files_to_clean = [
        os.path.join(base_dir, "jfglzsn", "Form2.vb"),
        os.path.join(base_dir, "jfglzsn", "Form4.vb"),
        os.path.join(base_dir, "jfglzsn", "Internal", "FilterStatus.vb"),
    ]
    
    for filepath in files_to_clean:
        if os.path.exists(filepath):
            if remove_il_labels(filepath):
                print(f"已清理: {filepath}")
            else:
                print(f"无需清理: {filepath}")

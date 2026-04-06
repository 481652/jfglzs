# Final cleanup script for remaining IL labels and goto statements
# This removes dead code patterns from VB.NET decompiled files

import re
import os

def clean_file(filepath):
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()
    
    original = content
    
    # Pattern 1: Remove standalone IL_xxxx: labels
    content = re.sub(r'^\s*IL_[0-9A-Fa-f]+:\s*\n', '\n', content, flags=re.MULTILINE)
    
    # Pattern 2: Remove goto statements that point to IL labels (dead code jumps)
    content = re.sub(r'\n\s*GoTo IL_[0-9A-Fa-f]+\s*\n', '\n', content)
    
    # Pattern 3: Remove dead code blocks between catch and end try
    # These are the result of decompilation artifacts
    content = re.sub(r'(Throw ProjectData\.CreateProjectError\([^)]+\))\s*\n\s*If \w+ <> 0 Then\s*\n\s*ProjectData\.ClearProjectError\(\)\s*\n\s*End If\s*\n', r'\1\n', content)
    
    # Pattern 4: Remove IL_xxxx: standalone labels that might remain
    content = re.sub(r'\n\s*IL_[0-9A-Fa-f]+:\s*\n', '\n', content)
    
    # Pattern 5: Clean up multiple consecutive empty lines
    content = re.sub(r'\n{3,}', '\n\n', content)
    
    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False

def main():
    base_path = r"E:\下载\f163067366\jfglzs"
    
    files_to_clean = [
        os.path.join(base_path, "jfglzsn", "Form1.vb"),
        os.path.join(base_path, "jfglzsn", "Form2.vb"),
        os.path.join(base_path, "jfglzsn", "Form4.vb"),
        os.path.join(base_path, "jfglzsn", "Internal", "FilterStatus.vb"),
    ]
    
    for filepath in files_to_clean:
        if os.path.exists(filepath):
            if clean_file(filepath):
                print(f"Cleaned: {filepath}")
            else:
                print(f"No changes: {filepath}")

if __name__ == "__main__":
    main()

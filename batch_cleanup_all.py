# Comprehensive cleanup script for all VB.NET decompiled files
# Removes IL labels, goto statements, and dead code patterns

import re
import os

def clean_vb_file(filepath):
    """Clean a single VB.NET file of decompilation artifacts"""
    try:
        with open(filepath, 'r', encoding='utf-8') as f:
            content = f.read()
    except:
        return False
    
    original = content
    
    # Pattern 1: Remove standalone IL_xxxx: labels
    content = re.sub(r'^\s*IL_[0-9A-Fa-f]+:\s*\n', '\n', content, flags=re.MULTILINE)
    
    # Pattern 2: Remove standalone end_IL_xxxx: labels
    content = re.sub(r'^\s*end_IL_[0-9A-Fa-f]+:\s*\n', '\n', content, flags=re.MULTILINE)
    
    # Pattern 3: Remove goto statements to IL labels (dead code)
    # Match goto followed by newline with dead code block
    content = re.sub(r'\n\s*GoTo IL_[0-9A-Fa-f]+\s*\n(\s*num\d+ = num\d+\s*\n\s*Dim num\d+ As Integer = num\d+ \+ 1\s*\n)?', '\n', content)
    
    # Pattern 4: Remove dead code after Throw before End Try
    content = re.sub(r'\n\s*Throw ProjectData\.CreateProjectError\([^)]+\)\s*\n\s*If \w+ <> 0 Then\s*\n\s*ProjectData\.ClearProjectError\(\)\s*\n\s*End If\s*\n', '\n', content)
    
    # Pattern 5: Remove IL_xxxx: inline labels (less common)
    content = re.sub(r'\n\s*IL_[0-9A-Fa-f]+:\s*\n', '\n', content)
    
    # Pattern 6: Clean up multiple empty lines
    content = re.sub(r'\n{3,}', '\n\n', content)
    
    if content != original:
        try:
            with open(filepath, 'w', encoding='utf-8') as f:
                f.write(content)
            return True
        except:
            return False
    return False

def main():
    base_path = r"E:\下载\f163067366\jfglzs"
    
    # All VB files to clean
    files_to_clean = [
        # about project
        os.path.join(base_path, "about", "WindowsApplication1", "Form3.vb"),
        os.path.join(base_path, "about", "Internal", "IteratorWrapper.vb"),
        
        # przs project
        os.path.join(base_path, "przs", "Form1.vb"),
        os.path.join(base_path, "przs", "Form2.vb"),
        os.path.join(base_path, "przs", "Internal", "Message.vb"),
        
        # set project
        os.path.join(base_path, "set", "WindowsApplication1", "load.vb"),
        os.path.join(base_path, "set", "WindowsApplication1", "Form3.vb"),
        os.path.join(base_path, "set", "WindowsApplication1", "Form1.vb"),
        os.path.join(base_path, "set", "Internal", "MessageCollection.vb"),
        
        # uninstall project
        os.path.join(base_path, "uninstall", "WindowsApplication1", "Form2.vb"),
        os.path.join(base_path, "uninstall", "WindowsApplication1", "Form1.vb"),
        os.path.join(base_path, "uninstall", "Internal", "DatabaseWrapper.vb"),
    ]
    
    cleaned_count = 0
    for filepath in files_to_clean:
        if os.path.exists(filepath):
            if clean_vb_file(filepath):
                print(f"[+] Cleaned: {filepath}")
                cleaned_count += 1
            else:
                print(f"[-] No changes: {filepath}")
        else:
            print(f"[!] Not found: {filepath}")
    
    print(f"\nTotal files cleaned: {cleaned_count}")

if __name__ == "__main__":
    main()

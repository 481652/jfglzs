# Ultra cleanup script - handles all remaining patterns
import re
import os

def ultra_clean(filepath):
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()
    
    original = content
    
    # Pattern: Remove dead code blocks after goto statements
    # Match: GoTo IL_xxxx followed by num assignment and return pattern
    content = re.sub(
        r'\n\s*GoTo IL_[0-9A-Fa-f]+\s*\n\s*num\d+ = num\d+\s*\n\s*Dim num\d+ As Integer = num\d+ \+ 1\s*\n',
        '\n', content
    )
    
    # Pattern: Remove empty if blocks followed by goto
    content = re.sub(
        r'\n\s*If [^{]+\s*\n\s*End If\s*\n\s*GoTo IL_[0-9A-Fa-f]+\s*\n',
        '\n', content
    )
    
    # Pattern: Remove goto + dead code + Catch pattern (multiple variations)
    content = re.sub(
        r'\n\s*GoTo IL_[0-9A-Fa-f]+\s*\n(\s*num\d+ = num\d+\s*\n)*(\s*Dim num\d+ As Integer = num\d+ \+ \d+\s*\n)*',
        '\n', content
    )
    
    # Pattern: Clean up trailing dead code before Catch
    content = re.sub(
        r'\n\s*num\d+ = num\d+\s*\n\s*Dim num\d+ As Integer = num\d+ \+ 1\s*\n\s*(?=Catch|Catch obj)',
        '\n', content
    )
    
    # Pattern: Remove multiple empty lines
    content = re.sub(r'\n{3,}', '\n\n', content)
    
    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False

def main():
    base = r"E:\下载\f163067366\jfglzs"
    
    files = [
        os.path.join(base, "przs", "Form1.vb"),
        os.path.join(base, "przs", "Form2.vb"),
        os.path.join(base, "set", "WindowsApplication1", "Form1.vb"),
        os.path.join(base, "set", "WindowsApplication1", "Form3.vb"),
        os.path.join(base, "set", "WindowsApplication1", "load.vb"),
        os.path.join(base, "uninstall", "WindowsApplication1", "Form1.vb"),
        os.path.join(base, "uninstall", "WindowsApplication1", "Form2.vb"),
    ]
    
    for f in files:
        if os.path.exists(f):
            if ultra_clean(f):
                print(f"[+] Cleaned: {f}")
            else:
                print(f"[-] No changes: {f}")

if __name__ == "__main__":
    main()

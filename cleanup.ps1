# 清理 VB 文件中的 IL 标签和 goto 语句
$baseDir = "E:\下载\f163067366\jfglzs\jfglzsn"

Get-ChildItem -Path $baseDir -Filter "*.vb" -Recurse | ForEach-Object {
    $file = $_.FullName
    $content = Get-Content $file -Raw -Encoding UTF8
    
    $original = $content
    
    # 移除 IL_xxxx: 标签行
    $content = $content -replace '\s*IL_[0-9a-f]+:\s*`n', "`n"
    
    # 移除 end_IL_xxxx: 标签
    $content = $content -replace '\s*end_IL_\w+:\s*;?\s*`n', "`n"
    
    # 移除 switch 语句
    $content = $content -replace '\s*switch\(ICSharpCode\.Decompiler\.ILAst\.ILLabel\[\],\s*\w+\)\s*`n', "`n"
    
    # 移除单独的 goto IL_xxxx;
    $content = $content -replace '\s*goto IL_[0-9a-f]+;\s*`n', "`n"
    
    # 移除多余的空行
    $content = $content -replace '\n{3,}', "`n`n"
    
    if ($content -ne $original) {
        Set-Content -Path $file -Value $content -Encoding UTF8 -NoNewline
        Write-Host "Cleaned: $file" -ForegroundColor Green
    }
}

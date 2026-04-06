#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
VB.NET 代码优化脚本
功能：
1. 清理 IL 标签和 Token 注释
2. 重命名混淆的变量
3. 简化控制流
"""

import re
import os
import shutil
from pathlib import Path

# VB.NET 变量名重命名映射
VARIABLE_MAPPING = {
    '_CustomerStatus': 'CustomerStatus',
    '_ExpressionStatus': 'ExpressionStatus',
    '_RecordStatus': 'RecordStatus',
    '_AttributeStatus': 'AttributeStatus',
    'stubStatus': 'StubStatus',
    '_PolicyStatus': 'PolicyStatus',
    'm_AuthenticationStatus': 'AuthStatus',
    'm_SingletonStatus': 'SingletonStatus',
    'm_ComparatorStatus': 'ComparatorStatus',
    '_ListStatus': 'ListStatus',
    '_RequestStatus': 'RequestStatus',
    'm_ObjectStatus': 'ObjectStatus',
    '_ServerStatus': 'ServerStatus',
    '_GetterStatus': 'GetterStatus',
    '_PropertyStatus': 'PropertyStatus',
    'm_MapStatus': 'MapStatus',
    '_RepositoryStatus': 'RepositoryStatus',
    '_AccountStatus': 'AccountStatus',
    'classStatus': 'ClassStatus',
    'productStatus': 'ProductStatus',
    '_DicStatus': 'DictStatus',
    '_RegistryStatus': 'RegistryStatus',
    'm_PredicateStatus': 'PredicateStatus',
    'annotationStatus': 'AnnotationStatus',
    'm_OrderStatus': 'OrderStatus',
    'refStatus': 'RefStatus',
    '_PoolStatus': 'PoolStatus',
    'm_IndexerStatus': 'IndexerStatus',
    'collectionStatus': 'CollectionStatus',
    'bridgeStatus': 'BridgeStatus',
    'm_ValueStatus': 'ValueStatus',
    '_ProcessStatus': 'ProcessStatus',
    'm_TaskStatus': 'TaskStatus',
    '_ExceptionStatus': 'ExceptionStatus',
    'systemStatus': 'SystemStatus',
    'm_ValStatus': 'ValStatus',
    'm_CandidateStatus': 'CandidateStatus',
    'methodStatus': 'MethodStatus',
    'm_InfoStatus': 'InfoStatus',
    '_InvocationStatus': 'InvocationStatus',
    '_RuleStatus': 'RuleStatus',
    'm_RoleStatus': 'RoleStatus',
    '_MockStatus': 'MockStatus',
    'fieldStatus': 'FieldStatus',
    'm_ConnectionStatus': 'ConnectionStatus',
    'm_MapperStatus': 'MapperStatus',
    'm_ComposerStatus': 'ServiceController',
    'm_ReponseStatus': 'ResponseController',
    '_InstanceStatus': 'InstanceStatus',
    '_ListenerStatus': 'ListenerStatus',
    'messageStatus': 'MessageStatus',
    'helperStatus': 'HelperStatus',
    'm_ParserStatus': 'ParserStatus',
    'printerStatus': 'PrinterStatus',
    '_FactoryStatus': 'FactoryStatus',
    '_ContainerStatus': 'ContainerStatus',
    '_QueueStatus': 'QueueStatus',
    '_RegStatus': 'RegistryWatcher',
    'm_TokenizerStatus': 'TokenizerStatus',
    'm_ResolverStatus': 'ResolverStatus',
    'm_ImporterStatus': 'ImporterStatus',
    'attrStatus': 'AttrStatus',
    'decoratorStatus': 'DecoratorStatus',
    'm_ObserverStatus': 'ObserverList',
    '_UtilsStatus': 'UtilsList',
    'm_WorkerStatus': 'WorkerStatus',
    'm_MappingStatus': 'MappingStatus',
    '_AdvisorStatus': 'AdvisorStatus',
    '_ErrorStatus': 'ErrorStatus',
    'contextStatus': 'ContextStatus',
}

# VB.NET 方法名重命名映射
METHOD_MAPPING = {
    'CalculateState': 'InitializeForm',
    'NewState': 'Form_Load',
    'AssetState': 'Form_Closing',
    'CompareState': 'Timer_Main_Tick',
    'SortState': 'Timer_Usb_Tick',
    'ResolveState': 'Timer_Dzjs_Tick',
    'ExcludeState': 'Timer_Wangluo_Tick',
    'InstantiateState': 'Timer_Fhq_Tick',
    'DestroyState': 'Timer_Qdx_Tick',
    'MapState': 'Timer1_Tick',
    'ValidateState': 'Timer2_Tick',
    'InterruptState': 'CheckProcess',
    'FindState': 'LoadUrlContent',
    'FilterStatus': 'RegistryHelper',
    'TokenStatus': 'TokenHelper',
    'MapState': 'OnTimer1Tick',
    'ValidateState': 'OnTimer2Tick',
}

def clean_il_tokens(code):
    """清理 IL 标签和 Token 注释"""
    # 移除 ' Token: 0x... RID: ...' 注释行
    code = re.sub(r"\s*' Token: 0x[0-9A-Fa-f]+ RID: \d+.*", '', code)
    
    # 移除 ' RVA: 0x... File Offset: 0x...' 注释
    code = re.sub(r"\s*' RVA: 0x[0-9A-Fa-f]+ File Offset: 0x[0-9A-Fa-f]+", '', code)
    
    # 移除 IL_xx: 标签行
    code = re.sub(r'^\s*IL_\w+:\s*$', '', code, flags=re.MULTILINE)
    
    # 移除多余的空行
    code = re.sub(r'\n{3,}', '\n\n', code)
    
    return code

def rename_variables(code):
    """重命名混淆的变量"""
    for old_name, new_name in VARIABLE_MAPPING.items():
        # VB.NET 不使用 \b 边界，使用完整单词匹配
        pattern = r'\b' + old_name + r'\b'
        code = re.sub(pattern, new_name, code)
    return code

def rename_methods(code):
    """重命名混淆的方法"""
    for old_name, new_name in METHOD_MAPPING.items():
        pattern = r'\b' + old_name + r'\b'
        code = re.sub(pattern, new_name, code)
    return code

def simplify_goto(code):
    """简化多余的 goto 语句"""
    # 移除孤立的标签定义（只有标签没有实际代码）
    code = re.sub(r'^\s*IL_\w+:\s*\n', '\n', code, flags=re.MULTILINE)
    return code

def process_file(filepath):
    """处理单个文件"""
    print(f"处理: {filepath}")
    
    with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
        code = f.read()
    
    # 应用优化
    code = clean_il_tokens(code)
    code = rename_variables(code)
    code = rename_methods(code)
    code = simplify_goto(code)
    
    # 写回原文件
    with open(filepath, 'w', encoding='utf-8') as f:
        f.write(code)
    
    print(f"  -> 已更新")

def process_directory(base_dir):
    """处理整个目录"""
    dirs = ['about', 'jfglzsn', 'przs', 'set', 'uninstall', 'zmserv']
    
    for dir_name in dirs:
        dir_path = Path(base_dir) / dir_name
        if dir_path.exists():
            # 处理所有 .vb 文件
            for vb_file in dir_path.glob('*.vb'):
                process_file(vb_file)

def main():
    base_dir = r'E:\下载\f163067366\jfglzs'
    
    # 备份
    backup_dir = Path(base_dir) / 'backup_original'
    if not backup_dir.exists():
        print("正在创建备份...")
        for dir_name in ['about', 'jfglzsn', 'przs', 'set', 'uninstall', 'zmserv']:
            src = Path(base_dir) / dir_name
            if src.exists():
                shutil.copytree(src, backup_dir / dir_name)
        print("备份完成!\n")
    
    # 处理所有项目
    process_directory(base_dir)
    
    print(f"\n优化完成!")

if __name__ == '__main__':
    main()

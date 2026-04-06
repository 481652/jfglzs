#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
jfglzsn 代码优化脚本
功能：
1. 清理 IL 注释和标签
2. 简化 try-catch 状态机
3. 重命名混淆的变量
4. 规范化 Timer 属性名称
"""

import re
import os
import shutil
from pathlib import Path

# Timer 名称映射 (根据 AccessedThroughProperty 属性)
TIMER_MAPPING = {
    'configStatus': 'Timer1',
    'creatorStatus': 'Timer2',
    '_TestsStatus': 'Timer_main',
    '_ParamsStatus': 'Timer_usb',
    'm_ProducerStatus': 'Timer_dzjs',
    'm_BroadcasterStatus': 'Timer_wangluo',
    'm_ParameterStatus': 'Timer_jcm',
    '_ProxyStatus': 'Timer_fhq',
    '_MerchantStatus': 'Timer_qdx',
    '_TestStatus': 'Timer4',
    'callbackStatus': 'Timer_jiyu',
    '_ItemStatus': 'Timer_updatehosts',
    'facadeStatus': 'Timer_route',
}

# 变量名重命名映射 (基于功能推断)
VARIABLE_MAPPING = {
    # 状态变量
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

# 方法名重命名映射
METHOD_MAPPING = {
    'MapState': 'OnTimer1Tick',
    'ValidateState': 'OnTimer2Tick',
    'CompareState': 'OnTimerMainTick',
    'SortState': 'OnTimerUsbTick',
    'ResolveState': 'OnTimerDzjsTick',
    'ExcludeState': 'OnTimerWangluoTick',
    'InstantiateState': 'OnTimerFhqTick',
    'DestroyState': 'OnTimerQdxTick',
    'InterruptState': 'CheckProcess',
    'FilterStatus': 'RegistryHelper',
    'TokenStatus': 'TokenHelper',
}

def clean_il_comments(code):
    """清理 IL 标签和注释"""
    # 移除 IL_xxxx: 标签行 (行首到冒号)
    code = re.sub(r'^\s*IL_[0-9a-f]+:\s*\n', '\n', code, flags=re.MULTILINE)
    
    # 移除 Token:, RVA:, .method 等元数据注释
    code = re.sub(r'// Token: [0-9a-fx]+', '', code)
    code = re.sub(r'// RVA: 0x[0-9a-f]+', '', code)
    
    # 移除 ILSpy 状态机相关注释
    code = re.sub(r'/\*Note: ILSpy.*?\*/;?', '', code, flags=re.DOTALL)
    code = re.sub(r'// Note:.*?\(emulated by.*?\)', '', code, flags=re.IGNORECASE)
    
    # 清理 end_IL_xxxx: 标签
    code = re.sub(r'^\s*end_IL_\w+:\s*;?\s*\n', '\n', code, flags=re.MULTILINE)
    
    # 移除 switch 块中的 default: goto end_IL_xxxx; 模式，简化状态机
    # 将 goto end_IL_xxxx; 替换为 break;
    code = re.sub(r'goto end_IL_\w+;', 'break;', code)
    
    # 移除多余的空行
    code = re.sub(r'\n{3,}', '\n\n', code)
    
    return code

def simplify_try_catch(code):
    """简化 try-catch 状态机结构"""
    # 这是一个复杂的过程，需要保留原始逻辑
    # 目前只做基本的清理
    return code

def rename_variables(code):
    """重命名混淆的变量"""
    for old_name, new_name in VARIABLE_MAPPING.items():
        # 匹配完整的变量名 (前后有边界)
        pattern = r'\b' + old_name + r'\b'
        code = re.sub(pattern, new_name, code)
    
    return code

def rename_methods(code):
    """重命名混淆的方法"""
    for old_name, new_name in METHOD_MAPPING.items():
        pattern = r'\b' + old_name + r'\b'
        code = re.sub(pattern, new_name, code)
    
    return code

def clean_timer_accessors(code):
    """清理 Timer 属性访问器中的混淆"""
    # 简化 Timer 属性的 get/set
    # 这需要更复杂的处理
    
    # 替换 timer.Tick -=/+= 事件处理
    for old_name, new_name in TIMER_MAPPING.items():
        # 替换 Timer 变量名
        code = code.replace(old_name, new_name.lower() + 'Timer')
    
    return code

def process_file(filepath, output_dir):
    """处理单个文件"""
    print(f"处理: {filepath}")
    
    # 读取文件
    with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
        code = f.read()
    
    # 应用各种清理
    code = clean_il_comments(code)
    code = rename_variables(code)
    code = rename_methods(code)
    code = clean_timer_accessors(code)
    
    # 创建输出目录
    output_path = Path(output_dir) / filepath.name
    output_path.parent.mkdir(parents=True, exist_ok=True)
    
    # 写入文件
    with open(output_path, 'w', encoding='utf-8') as f:
        f.write(code)
    
    print(f"  -> 已保存: {output_path}")

def main():
    """主函数"""
    source_dir = Path(r'E:\下载\f163067366\ilspy_jfglzsn\WindowsApplication1')
    output_dir = Path(r'E:\下载\f163067366\jfglzs_cleaned')
    
    # 备份原始文件
    backup_dir = output_dir / 'backup'
    if not backup_dir.exists():
        print("正在备份原始文件...")
        shutil.copytree(source_dir, backup_dir)
        print("备份完成!")
    
    # 处理所有 .cs 文件
    cs_files = list(source_dir.glob('*.cs'))
    for cs_file in cs_files:
        process_file(cs_file, output_dir)
    
    print(f"\n优化完成! 输出目录: {output_dir}")

if __name__ == '__main__':
    main()

using System;

using R5T.B0001;
using R5T.B0002;
using R5T.B0004;


namespace R5T.D0116.I0001
{
    public static class Instances
    {
        public static INamespaceNameOperator NamespaceNameOperator { get; } = B0002.NamespaceNameOperator.Instance;
        public static INamespaceNameTokenOperator NamespaceNameTokenOperator { get; } = B0002.NamespaceNameTokenOperator.Instance;
        public static ITypeName TypeName { get; } = B0001.TypeName.Instance;
        public static ITypeNameOperator TypeNameOperator { get; } = B0001.TypeNameOperator.Instance;
        public static IUsingDirectiveBlockLabel UsingDirectiveBlockLabel { get; } = B0004.UsingDirectiveBlockLabel.Instance;
        public static IUsingDirectiveBlockSortOrder UsingDirectiveBlockSortOrder { get; } = B0004.UsingDirectiveBlockSortOrder.Instance;
        public static IUsingNameAliasDirectiveBlockLabel UsingNameAliasDirectiveBlockLabel { get; } = B0004.UsingNameAliasDirectiveBlockLabel.Instance;
    }
}

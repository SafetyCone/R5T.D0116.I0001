using System;

using R5T.B0004;

using UsingDirectiveBlockSortOrder = R5T.D0116.T000.UsingDirectiveBlockSortOrder;

using Instances = R5T.D0116.I0001.Instances;


namespace System
{
    public static class IUsingDirectiveBlockSortOrderExtensions
    {
        public static UsingDirectiveBlockSortOrder RivetNamespaces(this IUsingDirectiveBlockSortOrder _)
        {
            var output = UsingDirectiveBlockSortOrder.From(
                Instances.UsingDirectiveBlockLabel.System(),
                Instances.UsingDirectiveBlockLabel.Microsoft(),
                Instances.UsingDirectiveBlockLabel.R5T_Named(),
                Instances.UsingDirectiveBlockLabel.R5T_Numbered(),
                Instances.UsingDirectiveBlockLabel.Default(),
                Instances.UsingDirectiveBlockLabel.LocalNamespace(),
                Instances.UsingDirectiveBlockLabel.Special());

            return output;
        }

        public static UsingDirectiveBlockSortOrder RivetNameAliases(this IUsingDirectiveBlockSortOrder _)
        {
            var output = UsingDirectiveBlockSortOrder.From(
                Instances.UsingNameAliasDirectiveBlockLabel.Interfaces(),
                Instances.UsingNameAliasDirectiveBlockLabel.Classes(),
                Instances.UsingNameAliasDirectiveBlockLabel.Default(),
                Instances.UsingNameAliasDirectiveBlockLabel.Documentation(),
                Instances.UsingNameAliasDirectiveBlockLabel.Instances());

            return output;
        }
    }
}

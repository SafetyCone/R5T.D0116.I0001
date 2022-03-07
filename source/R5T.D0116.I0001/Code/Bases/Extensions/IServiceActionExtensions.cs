using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0116.I0001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="RivetUsingNamespaceDirectiveBlockSortOrderProvider"/> implementation of <see cref="IUsingNamespaceDirectiveBlockSortOrderProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUsingNamespaceDirectiveBlockSortOrderProvider> AddRivetUsingNamespaceDirectiveBlockSortOrderProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IUsingNamespaceDirectiveBlockSortOrderProvider>(services => services.AddRivetUsingNamespaceDirectiveBlockSortOrderProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RivetUsingNameAliasDirectiveBlockSortOrderProvider"/> implementation of <see cref="IUsingNameAliasDirectiveBlockSortOrderProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUsingNameAliasDirectiveBlockSortOrderProvider> AddRivetUsingNameAliasDirectiveBlockSortOrderProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IUsingNameAliasDirectiveBlockSortOrderProvider>(services => services.AddRivetUsingNameAliasDirectiveBlockSortOrderProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="UsingNameAliasDirectiveBlockLabelProvider"/> implementation of <see cref="IUsingNameAliasDirectiveBlockLabelProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUsingNameAliasDirectiveBlockLabelProvider> AddUsingNameAliasDirectiveBlockLabelProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IUsingNameAliasDirectiveBlockLabelProvider>(services => services.AddUsingNameAliasDirectiveBlockLabelProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="UsingNamespaceDirectiveBlockLabelProvider"/> implementation of <see cref="IUsingNamespaceDirectiveBlockLabelProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUsingNamespaceDirectiveBlockLabelProvider> AddUsingNamespaceDirectiveBlockLabelProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IUsingNamespaceDirectiveBlockLabelProvider>(services => services.AddUsingNamespaceDirectiveBlockLabelProvider());
            return serviceAction;
        }
    }
}

using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0116.I0001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="RivetUsingNamespaceDirectiveBlockSortOrderProvider"/> implementation of <see cref="IUsingNamespaceDirectiveBlockSortOrderProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRivetUsingNamespaceDirectiveBlockSortOrderProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUsingNamespaceDirectiveBlockSortOrderProvider, RivetUsingNamespaceDirectiveBlockSortOrderProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RivetUsingNameAliasDirectiveBlockSortOrderProvider"/> implementation of <see cref="IUsingNameAliasDirectiveBlockSortOrderProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRivetUsingNameAliasDirectiveBlockSortOrderProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUsingNameAliasDirectiveBlockSortOrderProvider, RivetUsingNameAliasDirectiveBlockSortOrderProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="UsingNameAliasDirectiveBlockLabelProvider"/> implementation of <see cref="IUsingNameAliasDirectiveBlockLabelProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddUsingNameAliasDirectiveBlockLabelProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUsingNameAliasDirectiveBlockLabelProvider, UsingNameAliasDirectiveBlockLabelProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="UsingNamespaceDirectiveBlockLabelProvider"/> implementation of <see cref="IUsingNamespaceDirectiveBlockLabelProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddUsingNamespaceDirectiveBlockLabelProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUsingNamespaceDirectiveBlockLabelProvider, UsingNamespaceDirectiveBlockLabelProvider>();

            return services;
        }
    }
}

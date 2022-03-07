using System;
using System.Threading.Tasks;

using R5T.T0064;

using R5T.D0116.T000;


namespace R5T.D0116.I0001
{
    [ServiceImplementationMarker]
    public class RivetUsingNameAliasDirectiveBlockSortOrderProvider : IUsingNameAliasDirectiveBlockSortOrderProvider, IServiceImplementation
    {
        public Task<UsingDirectiveBlockSortOrder> GetUsingNameAliasDirectiveBlockSortOrder()
        {
            var usingNameAliasDirectivesSortOrder = Instances.UsingDirectiveBlockSortOrder.RivetNameAliases();

            return Task.FromResult(usingNameAliasDirectivesSortOrder);
        }
    }
}

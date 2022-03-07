using System;
using System.Threading.Tasks;

using R5T.T0064;

using R5T.D0116.T000;


namespace R5T.D0116.I0001
{
    [ServiceImplementationMarker]
    public class RivetUsingNamespaceDirectiveBlockSortOrderProvider : IUsingNamespaceDirectiveBlockSortOrderProvider, IServiceImplementation
    {
        public Task<UsingDirectiveBlockSortOrder> GetUsingNamespaceDirectiveBlockSortOrder()
        {
            var usingNamespaceDirectivesSortOrder = Instances.UsingDirectiveBlockSortOrder.RivetNamespaces();

            return Task.FromResult(usingNamespaceDirectivesSortOrder);
        }
    }
}

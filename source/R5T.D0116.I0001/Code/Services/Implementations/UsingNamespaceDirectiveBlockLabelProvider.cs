using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0116.I0001
{
    [ServiceImplementationMarker]
    public class UsingNamespaceDirectiveBlockLabelProvider : IUsingNamespaceDirectiveBlockLabelProvider, IServiceImplementation
    {
        public Task<string> GetBlockLabel(
            string namespaceName,
            string localNamespaceName)
        {
            string Internal()
            {
                // If the namespace is in local namespace (as in the namespace is a sub-namespace of the local namespace), use the local namespace block label.
                var isInLocalNamespace = Instances.NamespaceNameOperator.IsInNamespace(namespaceName, localNamespaceName);
                if (isInLocalNamespace)
                {
                    return Instances.UsingDirectiveBlockLabel.LocalNamespace();
                }

                var isInSystem = Instances.NamespaceNameOperator.IsInSystem(namespaceName);
                if (isInSystem)
                {
                    return Instances.UsingDirectiveBlockLabel.System();
                }

                var isInMicrosoft = Instances.NamespaceNameOperator.IsInMicrosoft(namespaceName);
                if (isInMicrosoft)
                {
                    return Instances.UsingDirectiveBlockLabel.Microsoft();
                }

                var isInR5T = Instances.NamespaceNameOperator.IsInR5T(namespaceName);
                if (isInR5T)
                {
                    var namespaceNameTokens = Instances.NamespaceNameOperator.Tokenize(namespaceName);

                    var repositoryNamespaceNameToken = Instances.NamespaceNameTokenOperator.GetRepositoryNamespaceNameToken(namespaceNameTokens);

                    var isNumbered = Instances.NamespaceNameTokenOperator.IsNumbered(repositoryNamespaceNameToken);
                    if (isNumbered)
                    {
                        return Instances.UsingDirectiveBlockLabel.R5T_Numbered();
                    }

                    // Otherwise, assume the repository namespace name token is named.
                    return Instances.UsingDirectiveBlockLabel.R5T_Named();
                }

                var isInLocalData = Instances.NamespaceNameOperator.IsInLocalData(namespaceName);
                if (isInLocalData)
                {
                    return Instances.UsingDirectiveBlockLabel.Special();
                }

                var output = Instances.UsingDirectiveBlockLabel.Default();
                return output;
            }

            var output = Internal();

            return Task.FromResult(output);
        }
    }
}

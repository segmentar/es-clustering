using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMappingCluster
    {
        public static SMMappingCluster Runtime_MakeMappingClusterNew(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC) 
        {
            SMMappingCluster clusterResult = default;

            clusterResult = MakeMappingClusterNew(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, SAPolicy.MappingClusterDebugPolicy);

            return clusterResult;
        }
    }
}

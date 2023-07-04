using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMappingCluster
    {
        public static SMMappingCluster MakeMappingClusterNew(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug) 
        {
            SMMappingCluster clusterResult = default;

            var information = new SMMappingClusterSequence(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, debug).Information;

            ArrayList.Add(information);

            clusterResult = new SMMappingCluster(information, information.Mapper, information.Map, information.Mapped, debug);

            return clusterResult;
        }
    }
}

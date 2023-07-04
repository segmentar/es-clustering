using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SVValidatingCluster
    {
        public static SVValidatingCluster Runtime_MakeValidatingClusterNew(SFFormed formed, IEnumerable<SFFormed> enumerable, SGText text)
        {
            SVValidatingCluster clusterResult = default;

            clusterResult = MakeValidatingCubicalNew(formed, enumerable, text, SAPolicy.ValidatingClusterDebugPolicy);

            return clusterResult;
        }
    }
}

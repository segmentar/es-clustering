using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SVValidatingCluster
    {
        public static SVValidatingCluster MakeValidatingCubicalNew(SFFormed formed, IEnumerable<SFFormed> enumerable, SGText text, Boolean debug)
        {
            SVValidatingCluster clusterResult = default;

            var information = new SVValidatingInformation();

            MakeValidatingClusterOneFirstVoid(information, formed, enumerable, text);

            MakeValidatingClusterTwoSecondVoid(information);

            clusterResult = new SVValidatingCluster(information, debug);

            return clusterResult;
        }
    }
}

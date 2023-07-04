using Core;

namespace Core.Shared
{
    using System;

    public partial class SFFormingCluster
    {
        public static SFFormingCluster Runtime_MakeFormingCluster(SGText text_FORM, SGText text_PARSE)
        {
            SFFormingCluster clusterResult = default;

            clusterResult = MakeFormingCluster(text_FORM, text_PARSE, SAPolicy.FormingClusterDebugPolicy);

            return clusterResult;
        }
    }
}

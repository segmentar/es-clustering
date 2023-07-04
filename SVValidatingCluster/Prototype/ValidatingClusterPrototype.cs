using Core;

namespace Core.Shared
{
    using System;

    public partial class SVValidatingCluster
    {
        public SVValidatingCluster(SVValidatingInformation information, Boolean debug)
        {
            this.Information = information;

            SVValidatingClusterData clusterData;

            clusterData = new SVValidatingClusterData();

            if (debug is true)
            {
                clusterData.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}

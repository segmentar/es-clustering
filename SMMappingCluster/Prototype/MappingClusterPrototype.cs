using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMappingCluster
    {
        public SMMappingCluster(SMMappingInformation information, SMMapper mapper, SMMap map, SMMapped mapped, Boolean debug)
        {
            this.Information = information;

            SMMappingClusterData clusterData;

            clusterData = new SMMappingClusterData();

            clusterData.Mapper = mapper;

            clusterData.Map = map;

            clusterData.Mapped = mapped;

            if (debug is true)
            {
                clusterData.IsDebug = true;
            }
            else
                "false".ToString();

            this.Data = clusterData;

            return;
        }
    }
}

using Core;

namespace Core.Shared
{
    using System;

    public partial class SFFormingCluster
    {
        public SFFormingCluster(SFFormingInformation information, SFFormer[] formerArray, SFFormed[] formedArray, SFForm[] formArray, Boolean debug)
        {
            this.Information = information;

            SFFormingClusterData clusterData;

            clusterData = new SFFormingClusterData();

            clusterData.FormerArray = formerArray;

            clusterData.FormedArray = formedArray;

            clusterData.FormArray = formArray;

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

using Core;

namespace Core.Shared
{
    using System;

    public partial class SEEscapingCluster
    {
        public SEEscapingCluster(SEEscapingInformation information, SEEscaper[] escaperArray, SEEscaped[] escapedArray, SEEscape[] escapeArray, Boolean debug)
        {
            this.Information = information;

            SEEscapingClusterData clusterData;

            clusterData = new SEEscapingClusterData();

            clusterData.EscaperArray = escaperArray;

            clusterData.EscapedArray = escapedArray;

            clusterData.EscapeArray = escapeArray;

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

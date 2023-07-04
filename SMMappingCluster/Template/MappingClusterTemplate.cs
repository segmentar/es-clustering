using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMappingCluster
    {
        public SMMappingCluster(SMMappingCluster mappingCluster, Boolean template, Boolean disposeMapper, Boolean disposeMap, Boolean disposeMapped)
        {
            if (template is true)
            {
                this.Data = mappingCluster.Data;

                if (disposeMapper is true)
                {
                    this.Data.Mapper = default(SMMapper);
                }
                else
                    "false".ToString();

                if (disposeMap is true)
                {
                    this.Data.Map = default(SMMap);
                }
                else
                    "false".ToString();

                if (disposeMapped is true)
                {
                    this.Data.Mapped = default(SMMapped);
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            if (template is true)
            {
                this.Data.IsTemplate = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}

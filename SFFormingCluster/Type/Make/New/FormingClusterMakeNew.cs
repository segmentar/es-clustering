using Core;

namespace Core.Shared
{
    using System;

    public partial class SFFormingCluster
    {
        public static SFFormingCluster MakeFormingCluster(SGText text_FORM, SGText text_PARSE, Boolean debug)
        {
            SFFormingCluster clusterResult = default;

            var information = new SFFormingInformation();

            var set_FORMER = SFFormer.Runtime_FomerDefaultSet(information, text_FORM);

            var set_FORMED = SFFormed.Runtime_FormedDefaultSet(information, set_FORMER);

            var set_FORM = SFForm.Runtime_FormDefaultSet(information, set_FORMED, text_PARSE);
            
            clusterResult = new SFFormingCluster(information, set_FORMER, set_FORMED, set_FORM, debug);

            return clusterResult;
        }
    }
}

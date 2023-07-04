using Core;

namespace Core.Shared
{
    using System;

    public partial class SFFormingCluster
    {
        public SFFormingCluster(SFFormingCluster formingCluster, Boolean template, Boolean disposeFormer, Boolean disposeFormed, Boolean disposeForm)
        {
            if (template is true)
            {
                this.Data = formingCluster.Data;
            }
            else
                "false".ToString();

            if (template is true)
            {
                this.Data.IsTemplate = true;
            }
            else
                "false".ToString();

            if (template is true)
            {
                if (disposeFormer is true)
                {
                    this.Data.FormerArray = new SFFormer[0];
                }
                else
                    "false".ToString();

                if (disposeFormed is true)
                {
                    this.Data.FormedArray = new SFFormed[0];
                }
                else
                    "false".ToString();

                if (disposeForm is true)
                {
                    this.Data.FormArray = new SFForm[0];
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            return;
        }
    }
}

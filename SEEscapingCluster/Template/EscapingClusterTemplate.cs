using Core;

namespace Core.Shared
{
    using System;

    public partial class SEEscapingCluster
    {
        public SEEscapingCluster(SEEscapingCluster escapingCluster, Boolean template, Boolean disposeEscaper, Boolean disposeEscaped, Boolean disposeEscape)
        {
            if (template is true)
            {
                this.Data = escapingCluster.Data;
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
                if (disposeEscaper is true)
                {
                    this.Data.EscaperArray = new SEEscaper[0];
                }
                else
                    "false".ToString();

                if (disposeEscaped is true)
                {
                    this.Data.EscapedArray = new SEEscaped[0];
                }
                else
                    "false".ToString();


                if (disposeEscape is true)
                {
                    this.Data.EscapeArray = new SEEscape[0];
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

using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SVValidatingCluster
    {
        public static void MakeValidatingClusterTwoSecondVoid(SVValidatingInformation information)
        {
            var list = new List<SVValidator>(information.Filtered.ValidatorSuccessList);

            information.Filtered.ValidatorSuccessList.Clear();

            foreach (SVValidator validator_ONE__FIRST in list)
            {
                foreach (SVValidator validator_TWO__SECOND in list)
                {
                    var safe_TWO__SECOND = (validator_ONE__FIRST.Expression.ToString() == validator_TWO__SECOND.Expression.ToString()) is true;

                    if (safe_TWO__SECOND is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    information.Filtered.ValidatorSuccessList.Remove(validator_TWO__SECOND);

                    continue;
                }

                information.Filtered.ValidatorSuccessList.Add(validator_ONE__FIRST);

                continue;
            }

            return;
        }
    }
}

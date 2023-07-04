using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SVValidatingCluster
    {
        public static void MakeValidatingClusterOneFirstVoid(SVValidatingInformation information, SFFormed formed, IEnumerable<SFFormed> enumerable, SGText text)
        {
            var list_VALIDATOR = new List<SVValidator>();

            var list_VALIDATOR__FAILURE = new List<SVValidator>();

            var volume = text.Value.Length;

            var indexer = 0;

            do
            {
                var safe_match__ONE_FIRST_contagious = false;

                safe_match__ONE_FIRST_contagious = safe_match__ONE_FIRST_contagious || (indexer < 0) is true;

                safe_match__ONE_FIRST_contagious = safe_match__ONE_FIRST_contagious || (indexer > volume) is true;

                safe_match__ONE_FIRST_contagious = safe_match__ONE_FIRST_contagious || (indexer == volume) is true;

                if (safe_match__ONE_FIRST_contagious)
                {
                    SLLogger.Runtime_MakeLoggerNew($"conn 1");

                    break;
                }
                else
                {
                    information.Position = indexer;
                }

                var validate = SVValidate.Runtime_MakeValidateNew(formed.Mapped.ResolverList);

                information.Validate = validate;

                var validator = SVValidator.Runtime_MakeValidatorNew(information, enumerable, text);

                information.Validator = validator;

                if (validator.IsSuccess is true)
                {
                    SLLogger.Runtime_MakeLoggerNew($"conn 3");

                    SEExpression.Execute(ref validator.Expression, 'a', validator.Expression, SEExpression.Runtime_MakeExpressionName(formed.Former.Data.Runtime.HeaderName));

                    list_VALIDATOR.Add(validator);
                }
                else
                {
                    list_VALIDATOR__FAILURE.Add(validator);
                }

                var safe_match__ZERO_TEN_feedback = true;

                safe_match__ZERO_TEN_feedback = safe_match__ZERO_TEN_feedback && (information.Feedback == -1) is false;

                safe_match__ZERO_TEN_feedback = safe_match__ZERO_TEN_feedback && (information.Feedback > indexer) is true;

                if (safe_match__ZERO_TEN_feedback)
                {
                    indexer = information.Feedback;
                }
                else
                {
                    indexer = indexer + 1;
                }

                continue;

            } while (true);

            var filtered = SFFiltered.Runtime_MakeFilteredNew(list_VALIDATOR, list_VALIDATOR__FAILURE);

            information.Filtered = filtered;

            return;
        }
    }
}

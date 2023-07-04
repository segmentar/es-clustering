using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMappingClusterSequence
    {
        public SMMappingInformation Information = default;

        public SMMappingClusterSequence(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            Debug(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, debug);

            var information = new SMMappingInformation();

            SATracker.MappingTrackerMapper = null;

            SATracker.MappingTrackerMap = null;

            SATracker.MappingTrackerMapped = null;

            var mapped = SMMapped.Runtime_MakeMappedNew(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC);

            var safe_ZERO__TEN_tracker = false;

            safe_ZERO__TEN_tracker = safe_ZERO__TEN_tracker || (mapped == default) is true;

            if (safe_ZERO__TEN_tracker is true)
            {
                return;
            }
            else
                "false".ToString();

            safe_ZERO__TEN_tracker = safe_ZERO__TEN_tracker || (SATracker.MappingTrackerMapper == default) is true;

            safe_ZERO__TEN_tracker = safe_ZERO__TEN_tracker || (SATracker.MappingTrackerMap == default) is true;

            safe_ZERO__TEN_tracker = safe_ZERO__TEN_tracker || (SATracker.MappingTrackerMapped == default) is true;

            if (safe_ZERO__TEN_tracker is true)
            {
                return;
            }
            else
                "false".ToString();

            information.Mapper = SATracker.MappingTrackerMapper;

            information.Map = SATracker.MappingTrackerMap;

            information.Mapped = SATracker.MappingTrackerMapped;

            this.Information = information;

            return;
        }

        ~SMMappingClusterSequence()
        {
            return;
        }
    }
}

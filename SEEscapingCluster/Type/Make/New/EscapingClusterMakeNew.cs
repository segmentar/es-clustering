using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SEEscapingCluster
    {
        public static SEEscapingCluster MakeEscapingClusterNew(IEnumerable<Char> enumerable, Boolean _switch_DIRECTION__, SGText text, Boolean debug)
        {
            SEEscapingCluster clusterResult = default;

            var list_SYMBOL = new List<SGSymbol>(SGSymbol.Runtime_SymbolFromCharacterSet(enumerable));

            var information = new SEEscapingInformation();

            var set_ESCAPER = SEEscaper.Runtime_EscaperDefaultSet(information, list_SYMBOL, text);

            var set_ESCAPED = SEEscaped.Runtime_EscapedDefaultSet(information, enumerable, list_SYMBOL, _switch_DIRECTION__, text);

            var set_ESCAPE = SEEscape.Runtime_EscapeDefaultSet(information, set_ESCAPER, set_ESCAPED);

            clusterResult = new SEEscapingCluster(information, set_ESCAPER, set_ESCAPED, set_ESCAPE, debug);

            return clusterResult;
        }
    }
}

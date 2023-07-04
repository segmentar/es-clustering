using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SEEscapingCluster
    {
        public static SEEscapingCluster Runtime_MakeEscapingClusterNew(IEnumerable<Char> enumerable, Boolean _switch_DIRECTION__, SGText text)
        {
            SEEscapingCluster clusterResult = default;

            clusterResult = MakeEscapingClusterNew(enumerable, _switch_DIRECTION__, text, SAPolicy.EscapingClusterDebugPolicy);

            return clusterResult;
        }
    }
}

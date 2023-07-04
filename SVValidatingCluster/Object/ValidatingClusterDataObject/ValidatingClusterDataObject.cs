using Core;

namespace Core.Shared
{
    using System;

    public partial struct SVValidatingClusterData
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SVValidatingCluster) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "data",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}'
            });
        }
    }
}

using Core;

namespace Core.Shared
{
    using System;

    public partial struct SMMappingClusterData
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SMMappingCluster) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsTemplate) + ':' + ' ' + IsTemplate,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Mapper) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Map) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Mapped) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Mapper) + ':',
                String.Empty + Mapper,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Map) + ':',
                String.Empty + Map,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(Mapped) + ':',
                String.Empty + Mapped
            });
        }
    }
}

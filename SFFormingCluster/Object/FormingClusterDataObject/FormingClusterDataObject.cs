using Core;

namespace Core.Shared
{
    using System;

    public partial struct SFFormingClusterData
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SFFormingCluster) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsTemplate) + ':' + ' ' + IsTemplate,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(FormerArray) + ':' + ' ' + ". . ." + ' ' + $"[{FormerArray.Length}]",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(FormedArray) + ':' + ' ' + ". . ." + ' ' + $"[{FormedArray.Length}]",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(FormArray) + ':' + ' ' + ". . ." + ' ' + $"[{FormArray.Length}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FormerArray) + ':',
                String.Empty +  String.Join('\n'.ToString(), (Object[])FormerArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(FormedArray) + ':',
                String.Empty +  String.Join('\n'.ToString(), (Object[])FormedArray),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(FormArray) + ':',
                String.Empty +  String.Join('\n'.ToString(), (Object[])FormArray)
            });
        }
    }
}

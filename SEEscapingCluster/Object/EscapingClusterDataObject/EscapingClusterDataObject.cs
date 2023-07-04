using Core;

namespace Core.Shared
{
    using System;

    public partial struct SEEscapingClusterData
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SEEscapingCluster) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsTemplate) + ':' + ' ' + IsTemplate,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(EscaperArray) + ':' + ' ' + ". . ." + ' ' + $"[{EscaperArray.Length}]",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(EscapedArray) + ':' + ' ' + ". . ." + ' ' + $"[{EscapedArray.Length}]",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(EscapeArray) + ':' + ' ' + ". . ." + ' ' + $"[{EscapeArray.Length}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(EscaperArray) + ':',
                String.Empty + String.Join('\n'.ToString(), (Object[])EscaperArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(EscapedArray) + ':',
                String.Empty + String.Join('\n'.ToString(), (Object[])EscapedArray),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(EscapeArray) + ':',
                String.Empty + String.Join('\n'.ToString(), (Object[])EscapeArray)
            });
        }
    }
}

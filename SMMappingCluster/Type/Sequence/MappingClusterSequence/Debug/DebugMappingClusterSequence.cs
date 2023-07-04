using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMappingClusterSequence
    {
        public static void Debug(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                var message = String.Join('\n'.ToString(), new String[] { 
                    String.Empty + nameof(SMMappingCluster) + ' ' + "::" + ' ' + nameof(SMMappingClusterSequence) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(symbol_LEFT) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(symbol_RIGHT) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(delimiter_LEFT) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(delimiter_RIGHT) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(text_STATIC) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(debug) + ':' + ' ' + debug,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(symbol_LEFT) + ':',
                    String.Empty + symbol_LEFT,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(symbol_RIGHT) + ':',
                    String.Empty + symbol_RIGHT,
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(delimiter_LEFT) + ':',
                    String.Empty + delimiter_LEFT,
                    String.Empty,
                    String.Empty + '~' + "40" + ' ' + nameof(delimiter_RIGHT) + ':',
                    String.Empty + delimiter_RIGHT,
                    String.Empty,
                    String.Empty + '~' + "50" + ' ' + nameof(text_STATIC) + ':',
                    String.Empty + text_STATIC
                });

                SLLogger.Runtime_MakeLoggerNew(message);
            }

            return;
        }
    }
}

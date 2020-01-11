using System.ComponentModel;

namespace Git4PL.Features.GitDiff
{
    public enum EncodingToSaveType
    {
        [Description("Сохранять в UTF-8")]
        UTF8 = 0,
        [Description("Сохранять в UTF-8 with BOM")]
        UTF8_BOM = 1,
        [Description("Не изменять существующий формат")]
        DontChange = 2
    }
}

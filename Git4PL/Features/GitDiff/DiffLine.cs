using System.Drawing;
using System.Linq;

namespace Git4PL.Features.GitDiff
{
    /// <summary>
    /// Строка которая будет отображаться в окне GitDiff
    /// </summary>
    public class DiffLine
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public int? LineNumA { get; private set; }
        public int? LineNumB { get; private set; }
        public char Type { get; private set; }
        public string Line { get; private set; }
        public Color ColorText { get
            {
                switch (Type)
                {
                    case '+': return Color.DarkGreen;
                    case '-': return Color.DarkRed;
                    case '@': return Color.Gray;
                    default: return Color.Black;
                }
            }
        }
        public Color ColorBack
        {
            get
            {
                switch (Type)
                {
                    case '+': return Color.LightGreen;
                    case '-': return Color.LightPink;
                    case '@': return Color.LightGray;
                    default: return Color.Transparent;
                }
            }
        }

        public DiffLine(string pLine, int? pLineNumA = null, int? pLineNumB = null)
        {
            Line = pLine + "\r\n";
            Type = pLine.DefaultIfEmpty(' ').FirstOrDefault();
            LineNumA = pLineNumA;
            LineNumB = pLineNumB;
        }

        /// <summary>
        /// Получить строку для отображения
        /// </summary>
        /// <param name="indent">ширина отступа</param>
        /// <returns></returns>
        public string ToStringWithLineIndent(int indent)
        {
            return string.Format("{0,"+indent+ "} {1," + indent + "} | {2}", LineNumA, LineNumB, Line);
        }
    }
}

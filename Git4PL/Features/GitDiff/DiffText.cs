using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Git4PL.Features.GitDiff
{
    /// <summary>
    /// Класс для построчного преобразования результата сравнения из консоли (git diff) к отображаемому типу в окне git diff в плагиен
    ///  ==> (Добавляются номера строк и цвет) <==
    /// 
    /// *****************************************************
    /// **  Пример, что приходит после сравнения файлов:   **
    /// *****************************************************
    /// 
    /// @@ -8,6 +8,7 @@ create or replace package body test4 is
    ///
    ///     function test2(a number) return number
    ///     is
    /// +   -- text
    ///     begin
    ///       return a* 4;
    ///     end;
    /// 
    /// *****************************************************
    /// **  То как это отображается в окне Git Diff:       **
    /// *****************************************************
    /// 
    ///       | @@ -8,6 +8,7 @@ create or replace package body test4 is
    ///  8  8 |   
    ///  9  9 |    function test2(a number) return number
    /// 10 10 |     is
    ///    11 | +   -- text
    /// 11 12 |     begin
    /// 12 13 |       return a* 4;
    /// 13 14 |     end; 
    /// 
    /// Как это работает, я конечно же не помню... 
    /// </summary>
    public class DiffText : IEnumerator
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private int Counter = -1;
        private int NumValA;
        private int NumCntA = -1;
        private int NumValB;
        private int NumCntB = -1;
        private int Indent = 1;

        public List<DiffLine> Lines { get; private set; }

        public object Current
        {
            get
            {
                return Lines[Counter];
            }
        }
        public DiffLine CurrentDiffLine
        {
            get
            {
                return Lines[Counter];
            }
        }
        public string GetCurrentLine
        {
            get
            {
                return (Current as DiffLine).ToStringWithLineIndent(Indent);
            }
        }

        public DiffText()
        {
            Lines = new List<DiffLine>();
        }
        public void AddLine(string line)
        {
            if (line.StartsWith("diff") || line.StartsWith("index"))
                return;
            if (line.StartsWith("@"))
            {
                int[] nums = SplitLineNumbers(line);
                NumValA = nums[0];
                NumCntA = nums[1];
                NumValB = nums[2];
                NumCntB = nums[3];
                Indent = Math.Max(Indent, (NumValA + NumCntA).ToString().Length);
                Lines.Add(new DiffLine(line));
                return;
            }
            else if (line.StartsWith("-"))
            {
                if (NumCntA-- >= 0)
                    Lines.Add(new DiffLine(line, NumValA++));
            }
            else if (line.StartsWith("+"))
            {
                if (NumCntB-- > 0)
                    Lines.Add(new DiffLine(line, null, NumValB++));
            }
            else if (NumCntA-- > 0 & NumCntB-- > 0)
                Lines.Add(new DiffLine(line, NumValA++, NumValB++));
            else
                Lines.Add(new DiffLine(line));
        }

        public override string ToString()
        {
            return string.Join("\r\n", Lines.Select(x => x.ToString()));
        }

        private int[] SplitLineNumbers(string s)
        {
            int[] ans = new int[4];
            MatchCollection mc = Regex.Matches(s, @"\d+");
            for (int i = 0; i < mc.Count; i++)
            {
                ans[i] = int.Parse(mc[i].Value);
                if (i == 3)
                    return ans;
            }
            return ans;
        }

        public bool MoveNext()
        {
            return ++Counter < Lines.Count;
        }

        public void Reset()
        {
            Counter = -1;
        }
    }
}

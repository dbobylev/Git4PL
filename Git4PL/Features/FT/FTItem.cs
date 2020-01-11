using Git4PL.PLSqlDeveloper.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.Features.FT
{
    public class FTItem
    {
        [SQL(ColumnName = "C1")]
        public string ISN { get; private set; }

        [SQL(ColumnName = "C2")]
        public string Code { get; private set; }

        [SQL(ColumnName = "C3")]
        public string Note { get; private set; }

        [SQL(ColumnName = "C4")]
        public string StatusStr { get; private set; }

        [SQL(ColumnName = "C5")]
        public string TaskId { get; private set; }

        [SQL(ColumnName = "C6")]
        public string UpdatedBy { get; private set; }

        [SQL(ColumnName = "C7")]
        public DateTime Updated { get; private set; }

        public bool Status
        {
            get
            {
                return StatusStr == "A";
            }
        }

        public FTItem()
        {
        
        }
    }
}
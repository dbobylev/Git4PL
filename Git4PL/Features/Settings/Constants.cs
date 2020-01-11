using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.Features.Settings
{
    abstract class Constants
    {
        public string SQL_FT { get; protected set; }
        public string SQL_TASKDB { get; protected set; }
        public string DBTASK_EXTENSION { get; protected set; }

        public string WEBTABLENAME1 { get; protected set; }
        public string WEBTABLENAME2 { get; protected set; }

        public string PATTERN_WEBTASKTYPE1 { get; protected set; }
        public string PATTERN_WEBTASKTYPE2 { get; protected set; }

        public string PATTERN_ISWEBTASK { get; protected set; }
        public string PATTERN_ISDBTASK { get; protected set; }
        public string PATTERN_GETWEBTASKID { get; protected set; }

        public string URL_REQUESTWEBTASK { get; protected set; }
        public string URL_OPENWEBTASK { get; protected set; }

        public string WARNIN_REGEX { get; protected set; }
        public string WARNOUT_REGEX { get; protected set; }

        private static Constants instanse;
        public static Constants Instance
        {
            get
            {
                if (instanse == null)
                {
                    Type type =  Type.GetType("Git4PL.Features.Settings.DefineConstantsSet2");
                    if (type != null)
                        instanse = (Constants)Activator.CreateInstance(type);
                    else
                        instanse = new DefineConstantsSet1();
                }
                return instanse;
            }
        }
    }
}

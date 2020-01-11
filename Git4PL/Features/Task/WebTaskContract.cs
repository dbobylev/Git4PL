using System.Runtime.Serialization;

namespace Git4PL.Features.Task
{
    /* 
     * Так как стоит простая задача, единожды распарсить входящий json - испольуем стандартные средства, вместо Json.NET - Newtonsoft 
     * Ниже модель ожидемых данных со стороные WEB-API
     */

    [DataContract]
    public class WebTaskContract
    {
        [DataMember]
        public string short_description { get; private set; }

        [DataMember]
        public string description { get; private set; }

        [DataMember]
        public WebTaskAssignedToContract assigned_to { get; private set; }

        [DataMember]
        public string state { get; private set; }

        [DataMember]
        public string opened_at { get; private set; }

        [DataMember]
        public string end_date { get; private set; }

        [DataMember]
        public string sys_id { get; private set; }    
    }

    [DataContract]
    public class WebTaskResultContract
    {
        [DataMember]
        public WebTaskContract[] result { get; private set; }
    }

    [DataContract]
    public class WebTaskAssignedToContract
    {
        [DataMember]
        public string display_value { get; private set; }

        [DataMember]
        public string link { get; private set; }
    }
}

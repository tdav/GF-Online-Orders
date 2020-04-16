using System;

namespace Apteka.SqlServer
{
    public partial class tbMonitorSyncs
    {
        public Guid Id { get; set; }
        public string TableName { get; set; }
        public string ClientIp { get; set; }
        public string ClientMac { get; set; }
        public DateTime CreateDate { get; set; }
        public int InsCount { get; set; }
        public int UpdCount { get; set; }
        public int SendCount { get; set; }
    }
}

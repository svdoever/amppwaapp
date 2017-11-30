using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmpPwaApps.Utils.Email
{
    public class EmailSettings
    {
        public string FromAddress { get; set; }
        public string FromAdressTitle { get; set; }
        public string ToAddress { get; set; }
        public string ToAddressTitle { get; set; }
        public string Subject { get; set; }
        public string BodyContent { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPortNumber { get; set; }
    }
}

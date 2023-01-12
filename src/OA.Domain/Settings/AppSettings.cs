using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Domain.Settings
{
    public class AppSettings
    {
        public ApplicationDetail ApplicationDetail { get; set; }
        public Serilog Serilog { get; set; }
        public string AllowedHosts { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
        public FeatureManagement FeatureManagement { get; set; }
        public MailSettings MailSettings { get; set; }
        public JWTSettings JWTSettings { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Part
    {
        public int PId { get; set; }
        public string PNameCN { get; set; }
        public string PNameEN { get; set; }
        public string PModel { get; set; }
        public int Lifecycle { get; set; }
        public string PKKS { get; set; }
        public string Manufacturer { get; set; }
        public string Provider { get; set; }
        public string PRemark { get; set; }
    }
}

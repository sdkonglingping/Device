using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Device
    {
        //DId, DNameCN, DNameEN, DType, DModel, DKKS, DArea, DStatus, StartDate, Manufacturer, Provider, DRemark
        public int DId { get; set; }
        public string DNameCN { get; set; }
        public string DNameEN { get; set; }
        public string DType { get; set; }
        public string DModel { get; set; }
        public string DKKS { get; set; }
        public string DArea { get; set; }
        public string DStatus { get; set; }
        public string StartDate { get; set; }
        public string Manufacturer { get; set; }
        public string Provider { get; set; }
        public string DRemark { get; set; }

    }
}

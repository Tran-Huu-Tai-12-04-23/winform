using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    internal class ExportDepartment
    {
        public string idBoPhanXuat {
            get; set; 
        }
        public string tenBoPhanXuat
        {
            get; set;
        }

        public ExportDepartment()
        {

        }
        public ExportDepartment(string idBoPhanXuat, string tenBoPhanXuat)
        {
           this.idBoPhanXuat = idBoPhanXuat;
           this.tenBoPhanXuat = tenBoPhanXuat;
        }
    
      
    }
}

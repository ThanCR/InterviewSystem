using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSystem.ET.Models
{
    //Product class that inherits from ProductType
    public class Product : Product
    {
        //Class attributes additional to inherited from ProductType
        public int IdProduct { get; set; } 

        public string ?ProductName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzeriaOrderApp
{
    public class UserOrder
    {
        public int UserID { get; set; }
        public string OrderItems { get; set; }
        public string OrderComments { get; set; }
    }
}

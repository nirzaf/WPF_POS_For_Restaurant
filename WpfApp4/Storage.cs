using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class Storage : Orders
    {
        private List<Orders> orderList = new List<Orders>();
        
        public Storage()
        {
        }

        public void Store(Orders order)
        {
            orderList.Add(order);
            return;
        }

    }
}

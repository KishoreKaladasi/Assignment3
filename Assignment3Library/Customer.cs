using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Library
{
    public class Customer
    {
        private int _custId;
        public int custId
        {
            get { return _custId; }
            set { _custId = value; }
        }
        private string _CustName;
        public string custname
        {
            get { return _CustName; }
            set { _CustName = value; }
        }
    }
}

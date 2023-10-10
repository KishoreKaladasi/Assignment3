using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Library
{
    public class Product
    {
        private int _prodid;

        //business rule
        public int ProductID
        {
            get { return _prodid; }
            set { _prodid = value; }
        }


        private string _prodname;

        public string ProductName
        {
            get { return _prodname; }
            set { _prodname = value; }
        }


        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }



        private float _qty;

        public float Quantity
        {
            get { return _qty; }
            set { _qty = value; }
        }


        public decimal CalculateTotalpurchase(float qty, decimal price)
        {
            decimal totalpurchase = price * Convert.ToDecimal(qty);
            return totalpurchase;
        }
    }
}

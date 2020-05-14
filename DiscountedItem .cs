using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double popust = 1.99;
        private double postotakPopusta;
       
        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            postotakPopusta = (100 * popust) / base.CalculatePrice();
          
            return postotakPopusta;
        }
        public override String Description
        {
            get
            {
                return "Now at "+this.postotakPopusta+"% off! " + base.Description;
            }
        }
    }
}

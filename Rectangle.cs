using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
   public class Rectangle
    {
        private int length, width;
        public int area;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public void Area_Rectangle()
        {
            area = 2*(length + width);
        }
        public int DisplayValue()
        {
            return area;
        }
    }
}

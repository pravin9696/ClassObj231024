using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObj231024
{
    internal class Circle
    {
        float r;
        public void SetRadius(float radius)//method1
        {
            r = radius;
        }
        public void ShowArea()//method2
        {
            float result = 3.14f * r * r;
            Console.WriteLine("Area of Circle :"+result);
        }
    }
}

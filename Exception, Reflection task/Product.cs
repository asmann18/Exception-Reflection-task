using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception__Reflection_task
{
    internal class Product
    {
        static int count=0;
        public int no;
        public string name;
        public double price;
        public Type type;
        public Product(string name,double price,Type type)
        {
            no = ++count;
            this.name = name;
            this.price = price;
            this.type = type;
    
        }
        public override string ToString()
        {
            return name + "   type:"+type+"   Price:"+price+" $ " ;
        }
    }

}

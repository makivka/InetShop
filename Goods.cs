using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InetShop
{
    class Goods
    {public string Name { get; set; }
        public Unit Units { get; set; }
        public float Price { get; set; }
        
        public string View()
        {
            string view = Name + "   " + Convert.ToString(Units) + "   "+ Convert.ToString(Price);
            return view;
        }
        public enum Unit 
        {
            piece,
            m,
            kg
        }
    }
}

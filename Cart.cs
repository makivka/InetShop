using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InetShop
{
    class Cart
    {
        List<Goods> GoodsCart { get; set; }
        public void AddToCart(Goods good)
        {
             GoodsCart.Add(good);
        }
        public void RemoveFromCart(Goods good)
        {
            GoodsCart.Remove(good);
        }
        public void View()
        {
            foreach ( var good in GoodsCart)
            {
                string printGood = good.View();
                Console.WriteLine(printGood);
            }
        }
    }
}

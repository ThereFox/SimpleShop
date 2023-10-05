using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buying.Products
{
    public class BuyingProduct
    {
        public BuyingProduct(int buingProductId, int count)
        {
            if(buingProductId < 0)
            {
                throw new IndexOutOfRangeException("Product id out of range");
            }
            if(count < 0)
            {
                throw new ArgumentOutOfRangeException("count lower value");
            }

            BuingProductId = buingProductId;
            Count = count;
        }

        public int BuingProductId { get; init; }
        public int Count { get; init; }

    }
}

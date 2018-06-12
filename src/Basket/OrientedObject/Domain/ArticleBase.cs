using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public abstract class ArticleBase
    {
        public ArticleBase(string id, int price)
        {
            Id = id;
            Price = price;
        }
        public int Price { get; }
        public string Id { get; }
        public abstract int CalculateAmout();
    }
}

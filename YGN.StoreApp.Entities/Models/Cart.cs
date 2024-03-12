﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.StoreApp.Entities.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; }
        public Cart()
        {
            Lines = new List<CartLine>();
        }
        public void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines.Where(x => x.Product.ProductId.Equals(product.ProductId)).FirstOrDefault();
            if (line is null)
            {
                Lines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product) =>
            Lines.RemoveAll(x => x.Product.ProductId.Equals(product.ProductId));

        public decimal ComputeTotalValue() => Lines.Sum(x => x.Product.Price * x.Quantity);

        public void Clear() => Lines.Clear();

    }
}

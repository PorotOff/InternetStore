using System;
using System.Collections.Generic;
using System.Linq;

namespace InternetStore
{
    public class Cart : IReadOnlyCart
    {
        private List<GoodsCell> _goodsCells = new List<GoodsCell>();

        public void ShowGoods()
        {
            foreach (var goodsCell in _goodsCells)
            {
                Console.WriteLine($"\"{goodsCell.Good.Name}\" - {goodsCell.Count} шт.");
            }
        }

        public void Add(Good good, int count)
        {
            if (count < 0)
                throw new Exception($"Negative value of {nameof(count)}");

            GoodsCell existingGoodsCell = _goodsCells.FirstOrDefault(cell => cell.Good.Name == good.Name);

            if (existingGoodsCell != null)
            {
                existingGoodsCell.Merge(good, count);
            }
            else
            {
                GoodsCell newGoodsCell = new GoodsCell(good, count);
                _goodsCells.Add(newGoodsCell);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace InternetStore
{
    public class Warehouse
    {
        private List<GoodsCell> _goodsCells = new List<GoodsCell>();

        public void Deliver(Good good, int count)
        {
            GoodsCell goodCell = new GoodsCell(good, count);
            _goodsCells.Add(goodCell);
        }

        public bool TryGetGoods(Good good, int count)
        {
            GoodsCell existingGoodsCell = _goodsCells.FirstOrDefault(cell => cell.Good.Name == good.Name);

            if (existingGoodsCell == null)
                throw new Exception($"Good {good.Name} doesn't exist");

            existingGoodsCell.RemoveGoods(good, count);
            RemoveEmptyCells();

            return true;
        }

        public void ShowGoods()
        {
            foreach (var goodsCell in _goodsCells)
            {
                Console.WriteLine($"\"{goodsCell.Good.Name}\" - {goodsCell.Count} шт.");
            }
        }

        private void RemoveEmptyCells()
        {
            foreach(var goodsCell in _goodsCells)
            {
                if (goodsCell.Count == 0)
                {
                    _goodsCells.Remove(goodsCell);
                }
            }
        }
    }
}

using System;

namespace InternetStore
{
    public class GoodsCell
    {
        public GoodsCell(Good good, int count)
        {
            if (count < 0)
                throw new Exception($"Negative value of {nameof(count)}");

            Good = good;
            Count = count;
        }

        public Good Good { get; private set; }
        public int Count { get; private set; }

        public void Merge(Good good, int count)
        {
            if (good.Name != Good.Name)
                throw new Exception($"Different goods: {nameof(Good)} = {Good.Name}, {nameof(good)} = {good.Name}");

            if (count < 0)
                throw new Exception($"Negative value of {nameof(count)}");

            Count += count;
        }

        public void RemoveGoods(Good good, int count)
        {
            if (good.Name != Good.Name)
                throw new Exception($"Different goods: {nameof(Good)} = {Good.Name}, {nameof(good)} = {good.Name}");

            if (count < 0)
                throw new Exception($"Negative value of {nameof(count)}");

            if (Count < count)
                throw new ArgumentOutOfRangeException($"Warehouse goods less than need");

            Count -= count;
        }
    }
}

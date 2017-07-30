using System;
using System.Linq;

namespace CoinChangerKata.Tests
{
    public class CoinChanger
    {
        public CoinChanger()
        {
        }

        public int[] GetChange(int value, int[] coins)
        {
            var change = new int[coins.Length];
            var coinsList = coins.ToList();
            foreach (var c in coinsList.OrderByDescending(l=>l))
            {
                while (value >= c)
                {
                    change[coinsList.IndexOf(c)] += 1;
                    value -= c;
                }
            }
            return change;
        }
    }
}
using System;
using Xunit;

namespace CoinChangerKata.Tests
{
    public class CoinChangerTests
    {
        [Fact]
        public void NoChange()
        {
            var changer = new CoinChanger();

            var result = changer.GetChange(0, new[] {1});

            Assert.Equal(new[] { 0 }, result);
        }

        [Fact]
        public void NintyNineCentsInPennies()
        {
            var changer = new CoinChanger();

            var result = changer.GetChange(99, new[] { 1 });

            Assert.Equal(new[] { 99 }, result);
        }

        [Fact]
        public void FiveCentsInPenniesAndNickles()
        {
            var changer = new CoinChanger();

            var result = changer.GetChange(5, new[] { 1, 5 });

            Assert.Equal(new[] { 0, 1 }, result);
        }


        [Fact]
        public void SixCentsInPenniesAndNickles()
        {
            var changer = new CoinChanger();

            var result = changer.GetChange(6, new[] { 1, 5 });

            Assert.Equal(new[] { 1, 1 }, result);
        }

        [Fact]
        public void SixCentsInPenniesAndNicklesAndDimes()
        {
            var changer = new CoinChanger();

            var result = changer.GetChange(15, new[] { 10, 5, 1 });

            Assert.Equal(new[] { 1, 1, 0 }, result);
        }


        [Fact]
        public void BigTest()
        {
            var changer = new CoinChanger();

            var result = changer.GetChange(99, new[] { 50, 25, 10, 5, 1 });

            Assert.Equal(new[] { 1, 1, 2, 0, 4 }, result);
        }

        [Fact]
        public void BigTest2()
        {
            var changer = new CoinChanger();

            var result = changer.GetChange(99, new[] { 25, 10, 5, 1 });

            Assert.Equal(new[] { 3, 2, 0, 4 }, result);
        }
    }
}

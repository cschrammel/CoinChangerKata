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
    }
}

using CI_CD_test.Data;

namespace CI_CD_test
{
    public class DataTests
    {
        [Fact]
        public void Number_Of_Countries()
        {
            Assert.Equal(2, Countries.countryList.Count());
        }
    }
}
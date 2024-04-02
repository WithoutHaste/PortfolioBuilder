namespace DiagnosticsTest
{
    public class TimingTest
    {
        [Fact]
        public void TimeSortingAlgorithmsTest()
        {
            var results = Exercise11.TimeSortingAlgorithms();

            Assert.NotEmpty(results);
            foreach (var result in results) 
            {
                Assert.True(result.MillisecondRunTime > 0);
            }
        }
    }
}

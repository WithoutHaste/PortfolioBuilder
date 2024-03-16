namespace HappyNumbersTest
{
    internal static class Utils
    {
        internal static void AssertMatch(int[] a, int[] b)
        {
            Assert.Equal(a.Length, b.Length);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.Equal(a[i], b[i]);
            }
        }
    }
}

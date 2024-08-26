using Learning.Manto;

namespace Tests.Learning.MantoTests
{
    public class MantoBubbleSortTests
    {
        [Theory]
        [InlineData(new int[] {9, 1, 2, 3, 10, 5, 5}, new int[] { 1, 2, 3, 5, 5, 9, 10 })]
        [InlineData(new int[] { 5 }, new int[] { 5 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] {1, 2, 3, 4}, new int[] {1, 2, 3, 4})]
        [InlineData(new int[] {-1, -2, -3, -4, 88, 65, -87, -200 }, new int[] {-200, -87, -4, -3, -2, -1, 65, 88})]
        [InlineData(new int[] { 0, 5, 1, 7}, new int[] {0, 1, 5, 7})]
        public void SortTest(int[] arrayToSort, int[]expectedResult)
        {
            var actualResult = MantoBubbleSort.Sort(arrayToSort);
            for (int i = 0; i < arrayToSort.Length; i++)
            { 
                Assert.Equal(expectedResult[i], actualResult[i]);
            }

        }
    }
}

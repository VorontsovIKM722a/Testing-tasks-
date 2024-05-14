using Testing_tasks;

namespace Testing_tasks.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(7, 5040)]
        [InlineData(0, 1)]
        [InlineData(10, 3628800)]
        public void FactTest(int input, int expected)
        {



            int actual = MathFunctions.Fact(input);


            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(7, false)]
        [InlineData(6, true)]
        [InlineData(-10, true)]
        public void EvenTest(int input, bool expected)
        {
            bool actual = MathFunctions.Even(input);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, true)]
        [InlineData(-7, true)]
        [InlineData(20, false)]
        public void PrimeTest(int input, bool expected)
        {
            bool actual = MathFunctions.Prime(input);


            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1, 7, -9, 8, 0 }, 8)]
        [InlineData(new int[] { -10, 0, 10 }, 10)]
        [InlineData(new int[] { 100, 50, 75, 200 }, 200)]
        public void ArrayMaxTest(int[] arr, int expected)
        {
           
            int actual = MathFunctions.ArrayMax(arr);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1, 7, -9, 8, 0 }, 8)]
        [InlineData(new int[] { -10, 0, 10 }, 10)]
        [InlineData(new int[] { 100, 50, 75, 200 }, 200)]
        public void ArrayAverageTest(int[] arr, int expected)
        {

            int actual = MathFunctions.ArrayMax(arr);

            Assert.Equal(expected, actual);
        }
    }
}
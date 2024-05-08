using Xunit;

public class UnitTests
{
    [Fact]
    public void TestOutOfbound()
    {
        int[] a = { 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 };
        int target1 = -5;
        int target2 = 321;
        Assert.Equal(-1, LeftClosestBinarySearch.ClosestBinarySearch(a, target1));
        Assert.Equal(-1, LeftClosestBinarySearch.ClosestBinarySearch(a, target2));
    }

    [Fact]
    public void TestClosestValue()
    {
        int[] a = { 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 };
        int target1 = 232;
        int target2 = 23;
        Assert.Equal(144, LeftClosestBinarySearch.ClosestBinarySearch(a, target1));
        Assert.Equal(21, LeftClosestBinarySearch.ClosestBinarySearch(a, target2));
    }

    [Fact]
    public void TestTargetValue()
    {
        int[] a = { 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 };
        int target1 = 3;
        int target2 = 21;
        Assert.Equal(3, LeftClosestBinarySearch.ClosestBinarySearch(a, target1));
        Assert.Equal(21, LeftClosestBinarySearch.ClosestBinarySearch(a, target2));
    }

    [Fact]
    public void TestEmptyArray()
    {
        int[] a = { };
        int target = 10;
        Assert.Equal(-1, LeftClosestBinarySearch.ClosestBinarySearch(a, target));
    }
}

class LeftClosestBinarySearch{
    public static int ClosestBinarySearch(int[] a, int target)
    {
        if (a.Length == 0)
        {
            Console.WriteLine("array is empty");
            return -1;
        }
        if (Enumerable.Range(a.First(), a.Last()).Contains(target))
        {
            int low = 0;
            int high = a.Length - 1;
            int leftClosest = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (a[mid] == target)
                {
                    Console.WriteLine($"found exact match: {a[mid]}");
                    return a[mid];
                }
                if (a[mid] < target)
                {
                    leftClosest = mid;
                    low = mid + 1;
                }
                else{
                    high = mid - 1;
                }
            }
            Console.WriteLine($"found left closest: {a[leftClosest]}");
            return a[leftClosest];
        }
        else
        {
            Console.WriteLine("out of bound");
            return -1;
        }
    }
}
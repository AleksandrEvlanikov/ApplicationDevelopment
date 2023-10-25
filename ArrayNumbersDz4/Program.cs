namespace ArrayNumbersDz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -2, -4, -6, -12, 5, 9, 12, 16, 22, 2, 7, 1, 24, 35, -18, -8, 4 };
            int target = 4;

            ArrayNumberFind FindArray = new ArrayNumberFind();
            FindArray.FindTarget(target, arr);
        }
    }
}
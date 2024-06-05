namespace Assignment5._3._1
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            // Example usage:
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            int n = 1;
            int[] updatedFlowerbed = PlaceFlowers(flowerbed, n);
            Console.WriteLine("Updated flowerbed:");
            foreach (int spot in updatedFlowerbed)
            {
                Console.WriteLine(spot + " ");
            }
        }

        public static int[] PlaceFlowers(int[] flowerbed, int n)
        {
            int i = 0;
            while (i < flowerbed.Length && n > 0)
            {
                if (flowerbed[i] != 0)
                {
                    i += 2;
                }
                else if ((i == 0 || flowerbed[i - 1] == 0) && ((i + 1) == flowerbed.Length || flowerbed[i + 1] == 0))
                {
                    n--;
                    flowerbed[i] = 1;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            return flowerbed;
        }
    }
}

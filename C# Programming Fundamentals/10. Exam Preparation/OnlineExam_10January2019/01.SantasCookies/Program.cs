using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int amountBatches = int.Parse(Console.ReadLine());
        int totalBoxes = 0;

        for (int i = 0; i < amountBatches; i++)
        {
            int flourPerBatch = int.Parse(Console.ReadLine());
            int sugarPerBatch = int.Parse(Console.ReadLine());
            int cocoaPerBatch = int.Parse(Console.ReadLine());

            int flourCups = flourPerBatch / 140;
            int sugarCups = sugarPerBatch / 20;
            int cocoaCups = cocoaPerBatch / 10;

            int minIngredient = Math.Min(flourCups, Math.Min(sugarCups, cocoaCups));

            if (minIngredient <= 0)
            {
                Console.WriteLine("Ingredients are not enough for a box of cookies.");
            }
            else
            {
                int cookies = 170 * minIngredient / 25;
                int boxes = cookies / 5;

                Console.WriteLine("Boxes of cookies: {0}", boxes);
                totalBoxes += boxes;
            }
        }

        Console.WriteLine("Total boxes: {0}", totalBoxes);
    }
}
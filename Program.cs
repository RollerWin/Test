namespace Solution
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            int[] inputNumbers = new int[] { 1, 1, 1, 2, 2, 3, 3, 3 };
            
            DuplicateRemover remover = new DuplicateRemover();
            Console.WriteLine(remover.RemoveDuplicates(inputNumbers));
        }
    }
}
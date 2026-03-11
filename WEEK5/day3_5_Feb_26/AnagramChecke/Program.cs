namespace AnagramChecke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter comma separated words:");
            string[] words = Console.ReadLine().Split(',');

            string baseWord = new string(words[0].Trim().ToLower().OrderBy(c => c).ToArray());

            bool allAnagrams = true;

            foreach (string word in words)
            {
                string sortedWord = new string(word.Trim().ToLower().OrderBy(c => c).ToArray());

                if (sortedWord != baseWord)
                {
                    allAnagrams = false;
                    break;
                }
            }

            Console.WriteLine(allAnagrams);
        }
    }
}

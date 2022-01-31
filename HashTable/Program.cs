using System;

namespace HashTable
{
     class Program
    {
        public static void CountNumberOfOccurance(string paragraph)
        {
            Node<string, int> hashTabe = new Node<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string Word in words)
            {
                if (hashTabe.Exists(Word))
                    hashTabe.Add(Word.ToLower(), hashTabe.Get(Word) + 1);
                else
                    hashTabe.Add(Word.ToLower(), 1);
            }
            Console.WriteLine("Displaying after add operation ");
            hashTabe.Display();
        }
        static void Main(string[] args)
        {

            CountNumberOfOccurance("To be or not to be");
        }
    }
}

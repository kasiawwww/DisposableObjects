using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            TxtRepo repo = new TxtRepo();
            try
            {
                Console.WriteLine(repo.GetTextFromFile("Files/TextFile.txt"));
            }
            catch(Exception ex)
            {
                //log()
            }
            finally //finally wykonuje sie zawsze
            {
                repo.Dispose();               
            }

            using (TxtRepo repo2 = new TxtRepo())
            {
                Console.WriteLine("In using");
                Console.WriteLine(repo2.GetTextFromFile("Files/TextFile.txt"));
            }

            Console.Read();
        }
    }
}

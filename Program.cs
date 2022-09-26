//Eric Malmström
using funfeaturesspace;
using MathWorkspace;
using System.Runtime.CompilerServices;

namespace themain
{
    class TheMain
    {
        static void Main(string[] args)
        {
            
            FunFeatures funfeatures = new FunFeatures();
            funfeatures.Start();

            ContinueToNextPart();
            
            MathWorks mathworks = new MathWorks();
            mathworks.Start();
        }

        private static void ContinueToNextPart()
        {
            Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
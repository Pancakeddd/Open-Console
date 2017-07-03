    using Microsoft.CSharp;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;





// Main Commands
namespace console
{


    public class Echo : Command
    {

        public Echo()
        {

            cee.ceeee.Add(1, this);

        }

        public override void Run(string[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {

                Console.Write(input[i] + " ");

            }
            Console.WriteLine();


        }

    }
    // Echo Brick
    public class EchoBrick : Command
    {

        public EchoBrick()
        {

            cee.ceeee.Add(2, this);

        }

        public override void Run(string[] input)
        {



            Console.Write("[ ");
            for (int i = 1; i < input.Length; i++)
            {

                Console.Write(input[i] + " ");

            }
            Console.Write("]");
            Console.WriteLine();


        }

    }
    // Credits
    public class Credits : Command
    {

        public Credits()
        {

            cee.ceeee.Add(3, this);

        }

        public override void Run(string[] input)
        {



            Console.WriteLine("Made by Pancaked!");


        }

    }
    // Load
    public class Load : Command
    {

        public Load()
        {

            cee.ceeee.Add(4, this);

        }

        public override void Run(string[] input)
        {

            if (input[2] == "Load" || input[2] == "load")
            {

                try
                {
                    string[] sw = File.ReadAllLines(input[1]);
                    for (int i = 0; i < sw.Length; i++)
                    {
                        Console.WriteLine(sw[i]);
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ERROR!] Failed to load file, File may be nonexistant or corrupted");
                    Console.ForegroundColor = ConsoleColor.White;

                }

            }
            
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR!] Unknown Type");
                Console.ForegroundColor = ConsoleColor.White;

            }



        }

    }


   


}

    




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {

        
       
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            new Echo();
            new EchoBrick();
            new Credits();
            new Load();
          
            while (true)
            {
                
                
                Console.Write(">");
                string r = Console.ReadLine();
                string[] s = r.Split(' ');

                

                switch (s[0])
                {

                    case "echo":
                    case "Echo":
                        Command.cee.Run(1,s);
                        break;
                    case "echo.brick":
                    case "Echo.brick":
                    case "echo.Brick":
                    case "Echo.Brick":
                        Command.cee.Run(2, s);
                        break;

                    case "Credits":
                    case "credits":
                        Command.cee.Run(3, s);
                        break;
                    case "File":
                    case "file":
                        Command.cee.Run(4, s);
                        break;

                    

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        
                        Console.WriteLine(s[0] + " Is not a valid command.");

                        
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
            }
            
        }

        
    }
}

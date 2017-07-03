using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    // Store
    public class stor
    {
        public Dictionary<int, Command> ceeee = new Dictionary<int, Command>();

        public void Run(int i,string[] Input)
        {

            ceeee[i].Run(Input);
                
        }
    }
    // Command Template
    public abstract class Command
    {

        public static stor cee = new stor();
       
        public abstract void Run(string[] input);

    }
    // Echo
    

}


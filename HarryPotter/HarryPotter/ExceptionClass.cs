using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    class ExceptionClass : Exception
    {
    }
    class NoElementException : Exception
    {
        public NoElementException()
        {
           // Console.WriteLine("No wizards found with the given property and minimum value.");

        }

    }
    class InputException : Exception
    {
    }
    class ConvertException : Exception
    {
    }

    class InsertionException : Exception
    {
    }
    
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharp8Features.UserDeclaration
{
    internal class FileGenarator
    {
        internal bool WriteToFile(List<string> values)
        {
            using var file = new StreamWriter("NewFile.txt");
            
                if (!values.Any()) return false;

                foreach (var value in values)
                {
                    file.Write(value);
                }
                Console.WriteLine("FileWriten");
            

            return true;
        }
    }
}

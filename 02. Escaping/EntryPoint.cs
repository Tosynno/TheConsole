using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Escaping
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            //var input = "\tHello\r\n\tWorld!";
            //Console.WriteLine(input);
            //Console.WriteLine(ToLiteral(input));
            string exeFile = "word.exe";
            string pathTpExe = "C:\\Program Files\\Microsoft Word\\";
            Console.WriteLine(pathTpExe + exeFile);
            Console.WriteLine();
            string exeFile1 = "word.exe\"";
            string pathTpExe1 = "\"C:\\Program Files\\Microsoft Word\\";
            Console.WriteLine(pathTpExe1 + exeFile1);
            Console.WriteLine();
            string exeFile2 = @"word.exe""";
            string pathTpExe2 = @"""C:\Program Files\Microsoft Word\";
            Console.WriteLine(pathTpExe2 + exeFile2);
            Console.WriteLine();
            Console.WriteLine("C:\\Program Files\\\"Microsoft Word\"\\'visualStudio'");
            Console.WriteLine(@"C:\Program Files\""Microsoft Word""\'visualStudio'");
            Console.WriteLine();
            string exeFile3 = @"word.exe""";
            string pathTpExe3 = @"""C:\Program Files\Microsoft Word\";
            Console.WriteLine($"{{{pathTpExe3 + "}"}{exeFile3}}}");
            Console.ReadKey();
        }

        private static string ToLiteral(string input)
        {
            using (var writer = new StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    return writer.ToString();
                }
            }
        }
    }
}

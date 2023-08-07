using System;

namespace Translator{

    internal class Program
    {
    
        public static void Main(string [] args)
        {
  
            var path = args[0];
            var st = new SymbolTable();
            var reader = new StreamReader(path);
            var lexer = new Lexer(reader, st);

            Token t;
            do {
                t = lexer.GetNextToken();
                Console.WriteLine($"<{t.Type},{t.Value}>");
            } while (t.Type != ETokenType.EOF && t.Type != ETokenType.ERR);


            // Console.WriteLine(st);

        }
    }

}

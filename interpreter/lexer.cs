namespace Mirix
{

    namespace Interpreter
    {
        namespace Lexer
        {
            using System.Collections.Generic;
            using System;

            public sealed class Lexer
            {
                public static Token[] getTokens(char[] sourceCode)
                {
                    //The tokens
                    List<Token> tokens = new List<Token>();

                    //Loop through the array of characters and build up tokens
                    for (int i = 0; i < sourceCode.Length; i++)
                    {
                        //The current character
                        char currentChar = sourceCode[i];
                        Console.Out.WriteLine("Current character: " + currentChar);

                        //TODO: Add actual lexer code
                    }

                    return tokens.ToArray();
                }
            }

            public sealed class Token
            {
                //The actual token
                private string token;

                public Token(string token)
                {
                    this.token = token;
                }

                public string getToken()
                {
                    return token;
                }
            }
        }
    }
}
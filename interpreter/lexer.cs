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

                    //The current token build up
                    string currentToken = "";

                    //Loop through the array of characters and build up tokens
                    for (int i = 0; i < sourceCode.Length; i++)
                    {
                        //The current character
                        char currentChar = sourceCode[i];
                        Console.Out.WriteLine("Current character: " + currentChar);

                        //Skip all whitespaces
                        if (currentChar == ' ')
                        {
                            Console.Out.WriteLine("Skipping space character");

                            //Only create a token when there is a built token
                            if (!currentToken.Equals(""))
                            {
                                //We flush the `currentToken` and create a new token from it
                                //when we encounter a space
                                Token builtToken = new Token(currentToken);
                                Console.Out.WriteLine("Created token: \"" + builtToken.getToken() +"\"");
                                tokens.Add(builtToken);
                                
                                //Clear the `currentToken` token build-up
                                currentToken = "";
                            }
                        }
                        //When encountering a semi-colon
                        else if(currentChar == ';')
                        {
                            //TODO
                        }
                        //If not a whitespace then we collect characters
                        else
                        {
                            currentToken = currentToken + currentChar;
                        }

                        //TODO: Add actual lexer code
                    }

                    Console.Out.WriteLine("Bult token: " + currentToken);

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
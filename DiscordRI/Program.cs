using System;

namespace DiscordRI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a string: ");
            var input = Console.ReadLine();
            Console.WriteLine(RegionalI(input));
        }
        static string RegionalI(string input){
            string returnstring = "";
            string emote = ":regional_indicator_";
            var array = input.ToCharArray();
            foreach(char i in array){
                if(isAscii(i)){
                    if(i.ToString() != " "){
                        returnstring = returnstring + " " + emote + i.ToString() + ":";
                    }else if(i.ToString() == " "){
                        returnstring = returnstring + "   ";
                    }
                }
            }
            return returnstring;
        }
        static bool isAscii(char letter){
            char[] alphabet = new []{' ', 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'}; //There is probably a better way of doing this I don't know about.
            foreach(char alph in alphabet){
                if(alph == letter){
                    return true;
                }
            }
            return false;
        }
    }
}

// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using System.Xml.Serialization;

Console.WriteLine("Tekst Tukling");

void mainProgram() 
{

    Console.WriteLine("pick an option");
    Console.WriteLine("1: rotate a word");
    Console.WriteLine("2: change a word");
    Console.WriteLine();
    Console.WriteLine("any other key to close program");
    var choice = Console.ReadLine();
    
    switch (choice)
    {
        case "1":
            Console.WriteLine("write a word");
            var word1 = Console.ReadLine();
            rotated(word1);
            break;
        case "2":
            Console.WriteLine("write a word");
            var word2 = Console.ReadLine();
            changeWord(word2);
            break;
        default:
            Environment.Exit(0);
            break;
    }
}


void rotated(string word)
{
    char[] wordArray = word.ToCharArray();
    Array.Reverse(wordArray);
    string rotatedWord = new string(wordArray);
    Console.WriteLine(rotatedWord); 
}

void changeWord(string word)
{
    string changedWord = word.Replace('e', 'a');
    Console.WriteLine(changedWord); 
}

mainProgram();
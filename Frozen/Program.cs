using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string name;
            string item;

            public Frozen(string _Name, string _item)
            {
                name = _Name;
                item = _item;
            }
            public string Name { get { return name; } }
            public string Item { get { return item; } }
            



        }
        class FrozenList
        {
            List<Frozen> Characters;
            

            public FrozenList()
            {
                Characters = new List<Frozen>();
            }

            public void AddCharactersToList(string name, string item)
            {
                Frozen newFrozen = new Frozen(name, item);
                Characters.Add(newFrozen);
            }

            public void PrintAllCharacters()
            {
                foreach(Frozen character in Characters)
                {
                    Console.WriteLine($"{character.Name} wants {character.Item} for christmas");
                }
            }

          
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string filepath = @"C:\Users\opilane\samples";
            string fileName = @"Frozen.txt";
            string fullFilepath = Path.Combine(filepath, fileName);

            string[] linesFromfile = File.ReadAllLines(fullFilepath);

            FrozenList characters = new FrozenList();
            foreach(string line in linesFromfile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                string characterName = tempArray[0];
                string characterItem = tempArray[1];
                characters.AddCharactersToList(characterName, characterItem);
            }
            characters.PrintAllCharacters();
        }
    }
    
}

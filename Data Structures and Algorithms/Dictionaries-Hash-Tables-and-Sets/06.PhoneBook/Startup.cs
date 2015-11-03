namespace _06.PhoneBook
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            HashSet<string> phoneEntriesInput = ReadFile("../../phones.txt");
            HashSet<string> commandsInput = ReadFile("../../commands.txt");
            IList<Entry> phoneEntries = ParsePhoneEntries(phoneEntriesInput);

            PhoneBook phoneBook = new PhoneBook();

            foreach (var entry in phoneEntries)
            {
                phoneBook.Add(entry);
            }

            IList<ICommand<Entry>> commands = ParsePhonebookCommands(commandsInput, phoneBook);

            foreach (var command in commands)
            {
                var result = command.Execute();
            }
        }

        private static IList<ICommand<Entry>> ParsePhonebookCommands(HashSet<string> commandsInput, PhoneBook phoneBook)
        {
            List<ICommand<Entry>> commands = new List<ICommand<Entry>>();
            foreach (var command in commandsInput)
            {
                string[] commandParts = command.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                var parametres = commandParts[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                switch (parametres.Length)
                {
                    case 1: commands.Add(new FindCommand(phoneBook, parametres[0].Trim()));
                        break;
                    case 2: commands.Add(new FindCommand(phoneBook, parametres[0].Trim(), parametres[1].Trim()));
                        break;
                    default:
                        break;
                }
            }

            return commands;
        }

        private static IList<Entry> ParsePhoneEntries(IEnumerable<string> phoneEntriesInput)
        {
            List<Entry> entries = new List<Entry>();
            foreach (var entry in phoneEntriesInput)
            {
                string[] entryParts = entry.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                entries.Add(new Entry
                {
                    Name = entryParts[0].Trim(),
                    Town = entryParts[1].Trim(),
                    Number = entryParts[2].Trim()
                });
            }

            return entries;
        }

        private static HashSet<string> ReadFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            HashSet<string> inputLines = new HashSet<string>();
            string line = reader.ReadLine();
            while (line != null)
            {
                inputLines.Add(line);
                line = reader.ReadLine();
            }

            return inputLines;
        }
    }
}

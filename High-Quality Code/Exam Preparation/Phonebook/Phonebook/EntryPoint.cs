namespace Phonebook
{
    using System;
    using System.IO;
    using Phonebook.Contracts;

    public class EntryPoint
    {
        public static void Main()
        {
            IPrinter printer = new ConsolePrinter();
            IPhonebookRepository phonebook = new PhonebookRepository();
            IPhoneNumberConvertor phoneConvertor = new PhoneNumberConvertor();
            CommandManager commandManager = new CommandManager(phonebook, printer, phoneConvertor);

            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "End")
                {
                    break;
                }

                Command command = Command.Parse(inputData);

                commandManager.ProceedCommand(command);
            }
        }
    }
}

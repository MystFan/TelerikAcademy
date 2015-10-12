namespace Phonebook
{
    using System;
    using Phonebook.Common;
    using Phonebook.Contracts;

    public class Command : ICommand
    {
        private string name;
        private string[] parameters;

        public Command(string name, string[] parameters)
        {
            this.Name = name;
            this.Parameters = parameters;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Command name cannot be null or empty.");

                this.name = value;
            }
        }

        public string[] Parameters
        {
            get
            {
                return this.parameters;
            }

            set
            {
                Validator.CheckIfNull(value, "Command parameters cannot be null.");

                this.parameters = value;
            }
        }

        public static Command Parse(string commandString)
        {
            int braketsStartIndex = commandString.IndexOf('(');

            string commandName = commandString.Substring(0, braketsStartIndex);

            string commandBody = commandString.Substring(braketsStartIndex + 1, commandString.Length - braketsStartIndex - 2);

            string[] commandArguments = commandBody.Split(',');
            for (int j = 0; j < commandArguments.Length; j++)
            {
                commandArguments[j] = commandArguments[j].Trim();
            }

            Command command = new Command(commandName, commandArguments);
            return command;
        }
    }
}

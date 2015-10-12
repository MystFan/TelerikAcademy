namespace CalendarSystem
{
    using System;
    using CalendarSystem.Common;

    public class Command
    {
        private string commandName;
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
                return this.commandName;
            }

            private set 
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Command name cannot be null.");

                this.commandName = value;
            }
        }

        public string[] Parameters
        {
            get
            {
                return this.parameters;
            }

            private set
            {
                Validator.CheckIfNull(value, "Command parameters cannot be null.");

                this.parameters = value;
            }
        }

        public static Command Parse(string command)
        {
            int startWhiteSpaceIndex = command.IndexOf(' ');
            if (startWhiteSpaceIndex < 0)
            {
                throw new InvalidCommandException("Invalid command: " + command);
            }

            string commandName = command.Substring(0, startWhiteSpaceIndex);
            string arguments = command.Substring(startWhiteSpaceIndex + 1);

            var commandArguments = arguments.Split('|');
            for (int i = 0; i < commandArguments.Length; i++)
            {
                commandArguments[i] = commandArguments[i].Trim();
            }

            var resultCommand = new Command(commandName, commandArguments);
            return resultCommand;
        }
    }
}

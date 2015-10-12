namespace CalendarSystem
{
    using System;
    using CalendarSystem.Contracts;

    public class Program
    {
        private static void Main()
        {
            IEventsManager eventManager = new EventManager();
            var commandManager = new CommandManager(eventManager);

            while (true)
            {
                string commandInput = Console.ReadLine();

                if (commandInput == "End")
                {
                    break;
                }

                try
                {
                    Command command = Command.Parse(commandInput);
                    string commandResult = commandManager.ProcessCommand(command);
                    Console.WriteLine(commandResult);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

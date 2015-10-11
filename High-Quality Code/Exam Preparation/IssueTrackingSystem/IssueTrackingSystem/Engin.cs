namespace IssueTrackingSystem
{
    using System;
    using Contracts;

    public class Engine : IEngine
    {
        private IDispatcher dispatcher;

        public Engine(IDispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public Engine()
            : this(new Dispatcher())
        {
        }

        public void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == null)
                {
                    break;
                }

                command = command.Trim();

                try
                {
                    Endpoint endpoint = Endpoint.Parse(command);
                    string viewResult = this.dispatcher.DispatchAction(endpoint);
                    System.Console.WriteLine(viewResult);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

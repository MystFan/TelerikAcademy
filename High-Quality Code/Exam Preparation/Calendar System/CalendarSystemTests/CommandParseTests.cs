namespace CalendarSystemTests
{
    using CalendarSystem;
    using CalendarSystem.Common;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CommandParseTests
    {
        [TestMethod]
        public void CommandParseWithLocationShouldHave3Parameters()
        {
            string addCommand = "AddEvent 2012-01-21T20:00:00 | party Viki | home";
            Command command = Command.Parse(addCommand);

            Assert.AreEqual(3, command.Parameters.Length);
        }

        [TestMethod]
        public void CommandParseWithoutLocationShouldHave2Parameters()
        {
            string addCommand = "AddEvent 2012-01-21T20:00:00 | party Viki";
            Command command = Command.Parse(addCommand);

            Assert.AreEqual(2, command.Parameters.Length);
        }

        [TestMethod]
        public void CommandWithValidParametersShouldHaveCorrectName()
        {
            string addCommand = "AddEvent 2012-01-21T20:00:00 | party Viki";
            Command command = Command.Parse(addCommand);

            Assert.AreEqual("AddEvent", command.Name);
        }

        [TestMethod]
        public void CommandWithValidParametersShouldHaveCorrectDate()
        {
            string addCommand = "AddEvent 2012-01-21T20:00:00 | party Viki";
            Command command = Command.Parse(addCommand);

            Assert.IsTrue("2012-01-21T20:00:00" == command.Parameters[0]);
        }

        [TestMethod]
        public void CommandWithValidParametersShouldHaveCorrectTitle()
        {
            string addCommand = "AddEvent 2012-01-21T20:00:00 | party Viki";
            Command command = Command.Parse(addCommand);

            Assert.IsTrue("party Viki" == command.Parameters[1]);
        }

        [TestMethod]
        public void CommandWithValidParametersShouldHaveCorrectLocation()
        {
            string addCommand = "AddEvent 2012-01-21T20:00:00 | party Viki | home";
            Command command = Command.Parse(addCommand);

            Assert.IsTrue("home" == command.Parameters[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCommandException))]
        public void CommandWithInvalidCommandShouldThrow()
        {
            string addCommand = "AddEvent2012-01-21T20:00:00";
            Command command = Command.Parse(addCommand);
        }
    }
}

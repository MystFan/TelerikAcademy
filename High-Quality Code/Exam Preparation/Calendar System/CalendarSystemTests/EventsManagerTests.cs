namespace CalendarSystemTests
{
    using System;
    using CalendarSystem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EventManagerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EventManagerAddEventWithNullShouldThrow()
        {
            var manager = new EventManager();
            manager.AddEvent(null);
        }

        [TestMethod]
        public void EventManagerAddEventValidEventShouldNotThrow()
        {
            var manager = new EventManager();
            manager.AddEvent(new Event("Test title", "Location", DateTime.Now));
        }

        [TestMethod]
        public void EventManagerAddEventValidEventShouldBeAddedCorect()
        {
            var manager = new EventManager();
            manager.AddEvent(new Event("Test title", "Location", DateTime.Now));

            Assert.AreEqual(1, manager.EventsList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EventManagerDeleteEventsByTitleNullParameterShouldThrow()
        {
            var manager = new EventManager();
            manager.DeleteEventsByTitle(null);
        }

        [TestMethod]
        public void EventManagerDeleteValidParameterShouldDeleteEvent()
        {
            var manager = new EventManager();

            manager.EventsList.Add(new Event("Test title1", "Location1", new DateTime(2014, 12, 31)));
            manager.DeleteEventsByTitle("Test title1");

            Assert.AreEqual(0, manager.EventsList.Count);
        }
    }
}

namespace PhonebookTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Phonebook;
    using Phonebook.Contracts;

    [TestClass]
    public class PhonebookRepositoryTests
    {
        [TestMethod]
        public void AddPhoneShouldAddNewEntry()
        {
            PhonebookRepository repo = new PhonebookRepository();
            bool result = repo.AddPhone("Jhon", new List<string>() { "+359123456789" });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddPhoneShouldMargePhoneNumbers()
        {
            PhonebookRepository repo = new PhonebookRepository();
            bool result = repo.AddPhone("Jhon", new List<string>() { "+359123456789", "+35976543212" });
            result = repo.AddPhone("Jhon", new List<string>() { "+359123456789", "+35976543212" });

            Assert.AreEqual(2, repo.ListEntries(0, 1).ToList()[0].Phones.Count);
        }

        [TestMethod]
        public void ListEntriesShouldHaveCorrectCountPhoneNumbers()
        {
            PhonebookRepository repo = new PhonebookRepository();
            bool result = repo.AddPhone("Jhon", new List<string>() { "+359123456789", "+35976543212" });

            Assert.AreEqual(1, repo.ListEntries(0, 1).ToList().Count);
        }

        [TestMethod]
        public void ChangePhoneShouldChangeCorrectPhoneNumbers()
        {
            PhonebookRepository repo = new PhonebookRepository();
            bool result = repo.AddPhone("Jhon", new List<string>() { "+359123456789", "+35976543212" });
            repo.ChangePhone("+359123456789", "+359111111119");

            Assert.AreEqual("+359111111119|+35976543212", string.Join("|", repo.ListEntries(0, 1).ToList()[0].Phones));
        }
    }
}

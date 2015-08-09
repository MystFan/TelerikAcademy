namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void Test_CreateStudentSetFirstNameShouldBeCorect()
        {
            var firstName = "Doncho";
            var lastName = "Minkov";
            var studentNumber = 11111;

            var student = new Student(firstName, lastName, studentNumber);

            Assert.AreEqual(firstName, student.FirstName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SetStudentFirstNameWithNullShouldThrow()
        {
            string firstName = null;
            var lastName = "Minkov";
            var studentNumber = 11111;

            var student = new Student(firstName, lastName, studentNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_SetStudentFirstNameWithEmptyStringShouldThrow()
        {
            var firstName = "";
            var lastName = "Minkov";
            var studentNumber = 11111;

            var student = new Student(firstName, lastName, studentNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_CreateStudentSetLastNameWithNullShouldThrow()
        {
            string firstName = "John";
            string lastName = null;
            var studentNumber = 11111;

            var student = new Student(firstName, lastName, studentNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_SetStudentLastNameWithEmptyStringShouldThrow()
        {
            var firstName = "Jhon";
            var lastName = "";
            var studentNumber = 11111;

            var student = new Student(firstName, lastName, studentNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_SetStudentNumberWithInvalidValueShouldThrow()
        {
            var firstName = "Jhon";
            var lastName = "Minkov";
            var studentNumber = 9999;

            var student = new Student(firstName, lastName, studentNumber);
        }

        [TestMethod]
        public void Test_CourseStudentsAddStudentShouldBeCorect()
        {
            var firstName = "Jhon";
            var lastName = "Minkov";
            var studentNumber = 19999;

            var student = new Student(firstName, lastName, studentNumber);
            var course = new Course("CSharp");
            course.AddStudent(student);

            Assert.AreEqual(1, course.Students.Count);
        }


        [TestMethod]
        public void Test_CourseStudentsRemoveStudentShouldBeCorect()
        {
            var firstName = "Jhon";
            var lastName = "Minkov";
            var studentNumber = 19999;

            var student = new Student(firstName, lastName, studentNumber);
            var course = new Course("CSharp");
            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CourseStudentsGreaterThanOrEqualBy30ShouldThrow()
        {
            var course = new Course("CSharp");

            for (int i = 0; i < 31; i++)
            {
                var firstName = "Jhon" + i;
                var lastName = "Minkov";
                var studentNumber = 19999 - i;
                var student = new Student(firstName, lastName, studentNumber);
                course.AddStudent(student);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CourseAddStudentsWithNotUniqueNumberShouldThrow()
        {
            var firstName = "Jhon";
            var lastName = "Minkov";
            var studentNumber = 19999;

            var student = new Student(firstName, lastName, studentNumber);
            var course = new Course("CSharp");
            course.AddStudent(student);
            var invalidStudent = new Student("Ivo", "Kenov", 19999);
            course.AddStudent(invalidStudent);
        }

    }
}

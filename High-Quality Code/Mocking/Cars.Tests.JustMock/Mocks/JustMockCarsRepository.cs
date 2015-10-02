namespace Cars.Tests.JustMock.Mocks
{
    using System;
    using System.Linq;

    using Cars.Contracts;
    using Cars.Models;

    using Telerik.JustMock;

    public class JustMockCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            this.CarsData = Mock.Create<ICarsRepository>();
            Mock.Arrange(() => this.CarsData.Add(Arg.IsAny<Car>())).DoNothing();
            Mock.Arrange(() => this.CarsData.All()).Returns(this.FakeCarCollection);
            Mock.Arrange(() => this.CarsData.Search(Arg.AnyString)).Returns(this.FakeCarCollection.Where(c => c.Make == "BMW").ToList());
            Mock.Arrange(() => this.CarsData.GetById(Arg.AnyInt)).Returns(this.FakeCarCollection.First());
            // homework
            Mock.Arrange(() => this.CarsData.SortedByMake()).Returns(this.FakeCarCollection.OrderBy(c => c.Make).ToList());
            Mock.Arrange(() => this.CarsData.SortedByYear()).Returns(this.FakeCarCollection.OrderBy(c => c.Year).ToList());
            Mock.Arrange(() => this.CarsData.Add(Arg.Matches<Car>(c => c.Year < 1900 || c.Year > DateTime.Now.Year))).Throws(new ArgumentOutOfRangeException());
        }
    }
}

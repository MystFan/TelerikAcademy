namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    
    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
            //: this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        // homework
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddingCarShouldThrowArgumentOutOfRangeExceptionIfCarYearIsInvalidRange()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "318i",
                Year = DateTime.Now.AddYears(1).Year
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        // homework
        [TestMethod]
        public void SearchCarShouldReturnCollectionCarsWithSameModelOrMake()
        {
            string carModel = "bmv";

            var cars = (List<Car>)this.GetModel(() => this.controller.Search(carModel));

            Assert.AreEqual(2, cars.Count);
        }

        // homework
        [TestMethod]
        public void SortByMakeShouldReturnCollectionCarsOrdered()
        {
            string sortParameter = "make";

            var cars = (List<Car>)this.GetModel(() => this.controller.Sort(sortParameter));
            var makes = cars.Select(c =>  c.Make );

            Assert.AreEqual("Audi BMW BMW Opel", string.Join(" ", makes));
        }

        // homework
        [TestMethod]
        public void SortByYearShouldReturnCollectionCarsOrdered()
        {
            string sortParameter = "year";

            var cars = (List<Car>)this.GetModel(() => this.controller.Sort(sortParameter));
            var makes = cars.Select(c => c.Year);

            Assert.AreEqual("2005 2007 2008 2010", string.Join(" ", makes));
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}

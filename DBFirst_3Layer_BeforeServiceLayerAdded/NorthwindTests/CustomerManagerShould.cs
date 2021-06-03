using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBusiness;
using NorthwindData;
using Moq;
using Microsoft.EntityFrameworkCore;

namespace NorthwindTests
{
    class CustomerManagerShould
    {
        private CustomerManager _sut;
        ///////////////////////using Moq as a DUMMY//////////////////////////////

        [Ignore("Should fail")]
        [Test]
        public void BeAbleToConstruct_CustomerManager_ThisWontWork()
        {
            //Act
            _sut = new CustomerManager(null);
            //Assert
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
        }
        [Test]
        public void BeAbleToConstruct_CustomerManager()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            //Assert
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
        }
        ///////////////////////using Moq as a STUB//////////////////////////////
        ////HAPPY PATH FOR UPDATE METHOD////
        [Test]
        public void ReturnTrue_WhenUpdateIsCalled_WithValidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var originalCustomer = new Customer
            {
                CustomerId = "NAGLE",
                ContactName = "Liam Nagle",
                CompanyName = "Sparta Global",
                City = "Leicester",
                Region = "Midlands"
            };

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns(originalCustomer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            var result = _sut.UpdateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            //Assert
            Assert.That(result, Is.True);
        }
        ////SAD PATH FOR UPDATE METHOD////
        [Test]
        public void ReturnFalse_WhenUpdateIsCalled_WithInvalidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns((Customer)null);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            var result = _sut.UpdateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            //Assert
            Assert.That(result, Is.False);
        }
        ////HAPPY PATH FOR DELETE METHOD////
        [Test]
        public void ReturnTrue_WhenDeleteIsCalled_WithValidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var originalCustomer = new Customer
            {
                CustomerId = "NAGLE",
                ContactName = "Liam Nagle",
                CompanyName = "Sparta Global",
                City = "Leicester",
                Region = "Midlands"
            };

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns(originalCustomer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            var result = _sut.DeleteCustomer("NAGLE");

            //Assert
            Assert.That(result, Is.True);
        }
        ////HAPPY PATH FOR DELETE METHOD////
        [Test]
        public void ReturnFalse_WhenDeleteIsCalled_WithInvalidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns((Customer)null);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            var result = _sut.DeleteCustomer("NAGLE");
            //Assert
            Assert.That(result, Is.False);
        }
        ////SAD PATH FOR UPDATE METHOD THAT THROWS AND EXCEPTION
        [Test]
        public void ReturnFalse_WhenUpdateIsCalled_AndDataBaseExceptionIsThrown()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges()).Throws<DbUpdateConcurrencyException>();
            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.UpdateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            //Assert
            Assert.That(result, Is.False);
        }

        ////Behaviour based testing - VERIFYING that the correct methods are called for our ICustomerService by our CustomerManager
        ///
        [Test]
        public void CallsSaveCustomerChanges_WhenUpdateIsCalledWithValidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            _sut.UpdateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            mockCustomerService.Verify(cs => cs.SaveCustomerChanges(), Times.Exactly(1));
        }
        [Test]
        public void RemoveCustomer_IsNotCalled_WhenCreateMethodCalled()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            _sut.CreateCustomer("MANDA", "Nish Mandal", "Sparta Global");

            //Verify
            mockCustomerService.Verify(cs => cs.RemoveCustomer(It.IsAny<Customer>()), Times.Never);
        }
        [Test]
        public void CreateCustomer_IsNotCalled_WhenDeleteMethodCalled()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var originalCustomer = new Customer
            {
                CustomerId = "NAGLE",
                ContactName = "Liam Nagle",
                CompanyName = "Sparta Global",
                City = "Leicester",
                Region = "Midlands"
            };

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns(originalCustomer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            var result = _sut.DeleteCustomer("NAGLE");

            //Assert
            mockCustomerService.Verify(cs => cs.CreateCustomer(It.IsAny<Customer>()), Times.Never);
        }
        [Test]
        public void UpdateCustomer_IsNotCalled_WhenDeleteMethodCalled()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var originalCustomer = new Customer
            {
                CustomerId = "NAGLE",
                ContactName = "Liam Nagle",
                CompanyName = "Sparta Global",
                City = "Leicester",
                Region = "Midlands"
            };

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns(originalCustomer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            var result = _sut.DeleteCustomer("NAGLE");

            //Assert
            mockCustomerService.Verify(cs => cs.GetCustomerList(), Times.Never);
        }

        //Homework
        //Verify that particular methods are called or not called, when calling particular CustomerManager methods
        //Change the 2 methods above so they pass with strict behaviour.

    }
}

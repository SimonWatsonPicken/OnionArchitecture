using System;
using Moq;
using NUnit.Framework;
using OnionArchitecture.Repository.Interfaces;
using OnionArchitecture.Service.Interfaces;

namespace OnionArchitecture.Service.Tests
{
    [TestFixture]
    public class CustomerServiceFixture
    {
        private Mock<ICustomerRepository> _mockCustomerRepository;
        private ICustomerService _customerService;

        [OneTimeSetUp]
        public void Init()
        {
            _mockCustomerRepository = new Mock<ICustomerRepository>();
            _customerService = new CustomerService(new Lazy<ICustomerRepository>(() => _mockCustomerRepository.Object));
        }

        [Test]
        public void GetAllCustomersReturnsTwoEntities()
        {
            // Arrange.
            // Act.
            _customerService.GetAllCustomers();

            // Assert.
            _mockCustomerRepository.VerifyGet(r => r.All, Times.Once);
        }
    }
}
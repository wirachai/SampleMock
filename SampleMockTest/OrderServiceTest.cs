using Moq;
using NUnit.Framework;
using SampleMock.Interfaces;
using SampleMock.Models;
using SampleMock.Repositories;
using SampleMock.Services;
using SampleMock.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleMockTest
{
    [TestFixture]
    class OrderServiceTest
    {
        [Test]
        public void Create_ShouldSave_WhenValidValidation()
        {
            // arrange
            var stubValidator = new Mock<IValidator>();
            stubValidator.Setup(x => x.IsValid).Returns(true);

            var mockRepository = new Mock<IOrderRepository>();

            OrderService service = new OrderService();
            service.CreateValidator = stubValidator.Object;
            service.OrderRepository = mockRepository.Object;

            // act
            List<OrderItemModel> testData = new List<OrderItemModel>();
            testData.Add(new OrderItemModel() { ItemId = "ITM0001", Quantity = 1 });

            service.Create(testData);

            // assert
            mockRepository.Verify(x => x.Add(testData), Times.Once);
        }
    }
}

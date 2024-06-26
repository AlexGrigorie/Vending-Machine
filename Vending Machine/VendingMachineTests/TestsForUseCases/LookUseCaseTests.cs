﻿using Moq;
<<<<<<< HEAD
using VendingMachine_Business.Entities;
using VendingMachine_Business.Interfaces;
=======
using VendingMachine.Business.Entities;
using VendingMachine.Business.Interfaces;
using VendingMachine.Business.UseCase;
>>>>>>> main

namespace iQuest.VendingMachineTests.TestsForUseCases
{
    [TestClass]
    public class LookUseCaseTests
    {
        private Mock<IProductRepository> mockProductRepository;
        private Mock<IShelfView> mockShelfView;
        private Mock<ILoggerService> mockLoggerService;
        private LookUseCase lookUseCase;

        [TestInitialize]
        public void SetupTest()
        {
            mockProductRepository = new Mock<IProductRepository>();
            mockShelfView = new Mock<IShelfView>();
<<<<<<< HEAD
            mockLoggerService = new Mock<ILoggerService>();
            lookUseCase = new LookUseCase(mockProductRepository.Object, mockShelfView.Object, mockLoggerService.Object);
=======
            lookUseCase = new LookUseCase(mockProductRepository.Object, mockShelfView.Object);
>>>>>>> main
        }
        [TestMethod]
        public void HavingLookUseCase_WhenExecute_ThenDisplayAllProducts()
        {
            var products = new List<Product>
            {
                new Product {ColumnId = 11, Name= "Grape", Price = 2.99f, Quantity = 12 },
                new Product {ColumnId = 12, Name= "Orange", Price = 2.99f, Quantity = 1 },
                new Product {ColumnId = 13, Name= "Apple", Price = 2.99f, Quantity = 2 },

            };
            mockProductRepository.Setup(p => p.GetAll()).Returns(products);
            lookUseCase.Execute();
            mockShelfView.Verify(s => s.DisplayProducts(products), Times.Once);
        }
    }
}

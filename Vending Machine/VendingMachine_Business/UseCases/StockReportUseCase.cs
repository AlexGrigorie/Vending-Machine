﻿using VendingMachine_Business.Interfaces;
using VendingMachine_Business.Reports.Stock;

namespace VendingMachine_Business.UseCases
{
    internal class StockReportUseCase : IUseCase
    {
        private readonly IFileSerialization fileSerialization;
        private readonly IProductRepository productRepository;
        private readonly IReportsView reportsView;

        public StockReportUseCase(IFileSerialization fileSerialization, IProductRepository productRepository, IReportsView reportsView)
        {
            this.fileSerialization = fileSerialization ?? throw new ArgumentNullException(nameof(fileSerialization));
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository)); ;
            this.reportsView = reportsView ?? throw new ArgumentNullException(nameof(reportsView)); ;
        }
        public void Execute()
        {
            var stockProducts = productRepository.GetAll()
                                                 .Select(p => new Product { Name = p.Name, Quantity = p.Quantity }).ToList();
            fileSerialization.Serilizer(new StockReport(stockProducts), $"Stock Report - {reportsView.DisplayCurrentDateTime()}");
            reportsView.DisplaySuccessMessage();
        }
    }
}
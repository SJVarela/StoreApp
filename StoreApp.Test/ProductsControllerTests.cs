using Application.Services.Interfaces;
using Client.Controllers;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Persistance.Data;
using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace StoreApp.Test
{
    public class ProductsControllerTests
    {
        [Fact]
        public async void ControllerShouldGetProduct()
        {
            var testProduct = new Product() { Id = 1, Name = "TestPrduct", Price = 200 };
            var pServiceMock = new Mock<IProductService>();
            var oServiceMock = new Mock<IOrderService>();
            pServiceMock.Setup(service => service.GetProduct(It.IsAny<int>())).ReturnsAsync(testProduct);
            var controller = new ProductsController(pServiceMock.Object, oServiceMock.Object);

            var result = await controller.Edit(2) as ViewResult;

            Assert.Equal(result.ViewData.Model, testProduct);
        }

    }
}

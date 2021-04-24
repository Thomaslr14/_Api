using System.Collections.Generic;
using _Api.Controllers;
using _Api.Data.Collections;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace _ApiTest.Unit_Tests.ControllerTests
{
    [TestClass]
    public class ControllerVacinadoTest
    {
        private readonly Mock<IRepositoryVacinado> _repositoryVacinado;
        private readonly Mock<IEntityVacinado> _entityVacinado;
        private readonly VacinadoController _service;
        private readonly Mock<List<Vacinado>> _listVacinados;

        public ControllerVacinadoTest()
        {
            _repositoryVacinado = new Mock<IRepositoryVacinado>();
            _entityVacinado = new Mock<IEntityVacinado>();
            _listVacinados= new Mock<List<Vacinado>>();
            _service = new VacinadoController(_repositoryVacinado.Object);
        }

        
        [TestMethod]
        public void CreateVacinado_ControllerVacinado_ReturnStatusCode200()
        {
            //Arrange
             PessoaModel _pessoaModel = new PessoaModel()
           {
               Nome = "teste",
               Email = "teste",
               Sexo = "Masculino",
               Latitude = 90.090909,
               Longitude = 85.66666
           };
            
            //Act
            ActionResult result = _service.CreateVacinado(_pessoaModel);

            //Assert
            _repositoryVacinado.Verify(_ => _.Create(It.IsAny<IEntityVacinado>()), Times.Once());
             result.Should().BeOfType<ObjectResult>();
            ((ObjectResult)result).StatusCode.Should().Be(200);
        }

        [TestMethod]
        public void Create_ControllerInfectado_ReturnBadRequest()
        {
            //Arrange
           PessoaModel _pessoaModelError = new PessoaModel()
           {
               Nome = "teste",
               Email = "teste",
               Latitude = 90.090909,
               Longitude = null
           };
            
            //Act
            ActionResult result = _service.CreateVacinado(_pessoaModelError);
            
            //Assert
            result.Should().BeOfType<BadRequestObjectResult>();
            ((ObjectResult)result).StatusCode.Should().Be(400);        
        }

        [TestMethod]
        public void GetList_ControllerVacinado_ReturnStatusCode200()
        {
            //Arrange
            _repositoryVacinado.Setup(m => m.GetAll()).Returns(_listVacinados.Object);
           
            //Act
            ActionResult result = _service.GetList();
           
            //Assert
            _repositoryVacinado.Verify(_ => _.GetAll(), Times.Once);
            result.Should().BeOfType<OkObjectResult>();
            ((OkObjectResult)result).StatusCode.Should().Be(200); 
        }
    }
}
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

namespace _ApiTest.Unit_Tests.RepositoriesTests
{
    [TestClass]
    public class ControllerInfectadoTest
    {

        private readonly Mock<IRepositoryInfectado> _repositoryInfectado;
        private readonly Mock<IRepositoryVacinado> _repositoryVacinado;
        private readonly Mock<IEntityInfectado> _entityInfectado;
        private readonly InfectadoController _service;
        private readonly Mock<List<Infectado>> _listInfectados;

        public ControllerInfectadoTest()
        {
            _repositoryInfectado = new Mock<IRepositoryInfectado>();
            _entityInfectado = new Mock<IEntityInfectado>();
            _service = new InfectadoController(_repositoryInfectado.Object, _repositoryVacinado.Object);
            _listInfectados = new Mock<List<Infectado>>();
        }

        [TestMethod]
        public void CreateInfectado_ControllerInfectado_ReturnStatusCode200()
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
            ActionResult result = _service.CreateInfectado(_pessoaModel);

            //Assert
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
            ActionResult result = _service.CreateInfectado(_pessoaModelError);
            
            //Assert
            result.Should().BeOfType<BadRequestObjectResult>();
            ((ObjectResult)result).StatusCode.Should().Be(400);        
        }

        

        [TestMethod]
        public void GetList_ControllerInfectado_ReturnStatusCode200()
        {
            //Arrange
            _repositoryInfectado.Setup(m => m.GetAll()).Returns(_listInfectados.Object);
            
            //Act
            var result = _service.GetList();
            
            //Assert
            _repositoryInfectado.Verify(_ => _.GetAll(), Times.Once);
            result.Should().BeOfType<OkObjectResult>();
            ((OkObjectResult)result).StatusCode.Should().Be(200);        
        }
    }
}
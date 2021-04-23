using System.Collections.Generic;
using _Api.Controllers;
using _Api.Data.Collections;
using _Api.Interfaces.BaseInterfaces;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Models;
using _Api.Repositories;
using Bogus;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using Moq;

namespace _ApiTest.Unit_Tests.RepositoriesTests
{
    [TestClass]
    public class ControllerInfectadoTest
    {

        private readonly Mock<IRepositoryInfectado> _repositoryInfectado;
        private readonly Mock<IEntityInfectado> _entityInfectado;
        // private readonly Mock<IMongoConnect> _mongoDBConnect;
        private readonly InfectadoController _service;
        private readonly Mock<List<Infectado>> _listInfectados;

        public ControllerInfectadoTest()
        {
            _repositoryInfectado = new Mock<IRepositoryInfectado>();
            _entityInfectado = new Mock<IEntityInfectado>();
            _service = new InfectadoController(_repositoryInfectado.Object);
            _listInfectados = new Mock<List<Infectado>>();
        }

        [TestMethod]
        public void CreateInfectado_ControllerInfectado_ChamaMetodo()
        {
            //Arrange
            Faker<PessoaModel> fakeInfectado = new Faker<PessoaModel>();

            //Act
            _service.CreateInfectado(fakeInfectado);

            //Assert
            _repositoryInfectado.Verify(_ => _.Create(It.IsAny<IEntityInfectado>()), Times.Once());
        }

        [TestMethod]
        public void GetAll_ControllerInfectado_ChamaMetodo()
        {
            //Arrange
            _repositoryInfectado.Setup(m => m.GetAll()).Returns(_listInfectados.Object);
            //_repositoryInfectado.Setup(_ => _.GetAll()).Returns();

            //Act
            _service.GetList();

            //Assert
            _repositoryInfectado.Verify(_ => _.GetAll(), Times.Once);
           // _repositoryInfectado.Setup(_ => _.GetAll()).Returns(infectados);
            
        }

        [TestMethod]
        public void GetList_ControllerInfectado_StatusCode200()
        {
            //Arrange
            Faker<PessoaModel> _pessoamodel = new Faker<PessoaModel>();

            //Act
            var result = _service.CreateInfectado(_pessoamodel);

            //Assert
            result.Should().BeOfType<ActionResult>();
            ((StatusCodeResult)result).StatusCode.Should().Be(200);
            
        }

    }
}
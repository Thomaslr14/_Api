using System.Collections.Generic;
using _Api.Controllers;
using _Api.Data.Collections;
using _Api.Interfaces;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Models;
using _Api.Repositories;
using Bogus;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using MongoDB.Driver.GeoJsonObjectModel;
using Moq;

namespace _ApiTest.Unit_Tests.RepositoriesTests
{
    [TestClass]
    public class ControllerInfectadoTest
    {

        private readonly Mock<IRepositoryInfectado> _repositoryInfectado;
        private readonly Mock<IEntityInfectado> _entityInfectado;
        private readonly Mock<MongoDBConnect> _mongoDBConnect;
        private readonly InfectadoController _service;

        public ControllerInfectadoTest()
        {
            _repositoryInfectado = new Mock<IRepositoryInfectado>();
            _entityInfectado = new Mock<IEntityInfectado>();
            _mongoDBConnect = new Mock<MongoDBConnect>();
            _service = new InfectadoController(_repositoryInfectado.Object);
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
            var repo = new RepositoryInfectado(_mongoDBConnect.Object);
            var infectados = repo.GetAll();

            //Act
            _service.GetList();

            //Assert
            _repositoryInfectado.Verify(_ => _.GetAll(), Times.Once);
            _repositoryInfectado.Setup(_ => _.GetAll()).Returns(infectados);


        }

    }
}
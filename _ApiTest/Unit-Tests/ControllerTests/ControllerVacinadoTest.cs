using System.Collections.Generic;
using _Api.Controllers;
using _Api.Data.Collections;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Models;
using Bogus;
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
        public void CreateVacinado_ControllerVacinado_ChamaMetodo()
        {
            //Arrange
            Faker<PessoaModel> fakeVacinado = new Faker<PessoaModel>();
            
            //Act
            _service.CreateVacinado(fakeVacinado);

            //Assert
            _repositoryVacinado.Verify(_ => _.Create(It.IsAny<IEntityVacinado>()), Times.Once());
        }

        [TestMethod]
        public void GetAll_ControllerVacinado_ChamaMetodo()
        {
            //Arrange
            _repositoryVacinado.Setup(m => m.GetAll()).Returns(_listVacinados.Object);
           
            //Act
            _service.GetList();

            //Assert
            _repositoryVacinado.Verify(_ => _.GetAll(), Times.Once);
           
        }
    }
}
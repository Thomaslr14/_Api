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
        private readonly Mock<MongoDBConnect> _mongoDBConnect;

        public ControllerVacinadoTest()
        {
            _repositoryVacinado = new Mock<IRepositoryVacinado>();
            _entityVacinado = new Mock<IEntityVacinado>();
            _mongoDBConnect = new Mock<MongoDBConnect>();
        }

        
        [TestMethod]
        public void CreateVacinado_ControllerVacinado_ChamaMetodo()
        {
            //Arrange
            Faker<PessoaModel> fakeVacinado = new Faker<PessoaModel>();
            var service = new VacinadoController(_repositoryVacinado.Object);

            //Act
            service.CreateVacinado(fakeVacinado);

            //Assert
            _repositoryVacinado.Verify(_ => _.Create(It.IsAny<IEntityVacinado>()), Times.Once());
        }
    }
}
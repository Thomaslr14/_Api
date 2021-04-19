using _Api.Controllers;
using _Api.Data.Collections;
using _Api.Repositories;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using Moq;

namespace _ApiTest.ControllerTests
{
    [TestClass]
    public class ControllerTest
    {
        private readonly Mock<IMongoCollection<Infectado>> _infectadoCollectionTest;
        private readonly Mock<MongoDBConnect> _mongoDBConnectTest;
        private readonly Mock<RepositoryInfectado> _repositoryInfectadoTest;

        public ControllerTest()
        {
            _infectadoCollectionTest = new Mock<IMongoCollection<Infectado>>();
            _mongoDBConnectTest = new Mock<MongoDBConnect>();
            _repositoryInfectadoTest = new Mock<RepositoryInfectado>();
        }

        // [TestMethod]
        // public void GetList_Infectados_RetornaOk()
        // {
        //    var service = new RepositoryInfectado(_mongoDBConnectTest.Object);
        //     var result = service.GetAll();
        //     result.Should().BeOfType(typeof(ActionResult), because: "Foram retornados todos os valores");
        // }
    }
}
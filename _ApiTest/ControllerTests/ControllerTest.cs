using _Api.Data.Collections;
using _Api.Repositories;
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
    }
}
using _Api.Data.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using Moq;
using Bogus;
using _Api.Repositories;
using FluentAssertions;

namespace _ApiTest.RepositoriesTest
{
    [TestClass]
    public class RepositoryInfectadoTest
    {
        private readonly Mock<MongoDBConnect> _mongoDBConnect;

        private readonly Mock<IMongoCollection<Infectado>> _ICollectionInfectado;

        private readonly Mock<RepositoryInfectado> _repoInfectado;
        
        
        public RepositoryInfectadoTest()
        {   
            _mongoDBConnect = new Mock<MongoDBConnect>();
            _repoInfectado = new Mock<RepositoryInfectado>();
            _ICollectionInfectado = new Mock<IMongoCollection<Infectado>>();
        }

        [TestMethod]
        public void Create_RepositoryInfectado_Successful()
        {
            // Arrange
            var _infectado = new Faker<Infectado>();
            
            // Act
            var result = _repoInfectado.Object.Create(_infectado);

            // Assert
            result.Should().BeTrue(because: "O infectado foi contabilizado");

        }
        
    }
}   
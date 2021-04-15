using _Api.Data.Collections;
using MongoDB.Driver;

namespace _Api.Repositories
{
    public class RepositoryVacinado
    {
        protected IMongoCollection<Vacinado> _ListVacinado;
    }
}
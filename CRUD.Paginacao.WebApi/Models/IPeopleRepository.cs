using System.Collections.Generic;

namespace CRUD.Paginacao.WebApi.Models
{
    public interface IPeopleRepository
    {
        IEnumerable<People> GetAllByFilter(string name, int page);
        void Create(People people);
        People GetById(int id);
        void Delete(int id);
    }
}

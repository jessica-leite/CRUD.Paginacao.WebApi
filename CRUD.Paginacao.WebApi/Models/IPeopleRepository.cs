using System.Collections.Generic;

namespace CRUD.Paginacao.WebApi.Models
{
    public interface IPeopleRepository
    {
        IEnumerable<People> GetAllByFilter();
        void Create();
        People GetById();
        void Delete();
    }
}

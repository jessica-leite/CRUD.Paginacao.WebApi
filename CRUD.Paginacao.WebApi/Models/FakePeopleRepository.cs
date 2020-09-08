using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Paginacao.WebApi.Models
{
    public class FakePeopleRepository : IPeopleRepository
    {
        private IList<People> _peoples;
        private int _id;

        public FakePeopleRepository()
        {
            _peoples = new List<People>();
        }

        public void Create(People people)
        {
            people.Id = ++_id;
            _peoples.Add(people);
        }

        public void Delete(int id)
        {
            _peoples.Remove(GetById(id));
        }

        public IEnumerable<People> GetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public People GetById(int id)
        {
            return _peoples.FirstOrDefault(p => p.Id == id);
        }
    }
}

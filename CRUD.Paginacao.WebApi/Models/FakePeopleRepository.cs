using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Paginacao.WebApi.Models
{
    public class FakePeopleRepository : IPeopleRepository
    {
        private IList<People> _peoples;
        private int _id;
        private readonly int _itemsPerPage;

        public FakePeopleRepository()
        {
            _peoples = GenerateFakes();
            _itemsPerPage = 3;
        }

        private IList<People> GenerateFakes()
        {
            return new List<People>
            {
                new People{Id = 1, Name = "Josefina", BirthDate = new DateTime(1990, 1, 1), MaritalStatus = "Married", PartnerBirthDate = new DateTime(1990, 2,3), PartnerName = "Bolinha" },
                new People{Id = 2, Name = "Marcelo", BirthDate = new DateTime(1990, 1, 1), MaritalStatus = "Married", PartnerBirthDate = new DateTime(1990, 2,3), PartnerName = "Bolinha" },
                new People{Id = 3, Name = "Joana", BirthDate = new DateTime(1990, 1, 1), MaritalStatus = "Married", PartnerBirthDate = new DateTime(1990, 2,3), PartnerName = "Bolinha" },
                new People{Id = 4, Name = "Amanda", BirthDate = new DateTime(1990, 1, 1), MaritalStatus = "Married", PartnerBirthDate = new DateTime(1990, 2,3), PartnerName = "Bolinha" },
                new People{Id = 5, Name = "Gustavo", BirthDate = new DateTime(1990, 1, 1), MaritalStatus = "Married", PartnerBirthDate = new DateTime(1990, 2,3), PartnerName = "Bolinha" },
                new People{Id = 6, Name = "Juca", BirthDate = new DateTime(1990, 1, 1), MaritalStatus = "Married", PartnerBirthDate = new DateTime(1990, 2,3), PartnerName = "Bolinha" },
                new People{Id = 7, Name = "Brenda", BirthDate = new DateTime(1990, 1, 1), MaritalStatus = "Married", PartnerBirthDate = new DateTime(1990, 2,3), PartnerName = "Bolinha" },
            };
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

        public IEnumerable<People> GetAllByFilter(string name, int page)
        {
            page--;
            var peoples = _peoples
                .Skip(page * _itemsPerPage)
                .Take(_itemsPerPage)
                .Where(p => p.Name.Contains(name));

            return peoples;
        }

        public People GetById(int id)
        {
            return _peoples.FirstOrDefault(p => p.Id == id);
        }
    }
}

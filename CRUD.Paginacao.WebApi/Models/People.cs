using System;

namespace CRUD.Paginacao.WebApi.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime BirthDate { get; set; }
        public string PartnerName { get; set; }
        public DateTime? PartnerBirthDate { get; set; }
    }
}

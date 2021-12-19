using dotnetsln2.Models;
using dotnetsln2.Repository.Generic;
using System.Collections.Generic;

namespace dotnetsln2.Business.Implementations
{
    public class EnderecoBusiness : IEnderecoBusiness
    {
        private readonly IRepository<Endereco> _repository;

        public EnderecoBusiness(IRepository<Endereco> repository)
        {
            _repository = repository;
        }

        public Endereco Create(Endereco item)
        {
            return _repository.Create(item);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public Endereco Edit(Endereco item)
        {
            return _repository.Edit(item);
        }

        public List<Endereco> FindAll()
        {
            return _repository.FindAll();
        }

        public Endereco FindById(long id)
        {
            return _repository.FindById(id);
        }
    }
}

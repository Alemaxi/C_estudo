using dotnetsln2.Models;
using dotnetsln2.Repository.Generic;
using System.Collections.Generic;

namespace dotnetsln2.Business.Implementations
{
    public class PessoaBusiness : IPessoaBusiness
    {
        private readonly IRepository<Pessoa> _repository;

        public PessoaBusiness(IRepository<Pessoa> repository)
        {
            _repository = repository;
        }

        public Pessoa Create(Pessoa item)
        {
            return _repository.Create(item);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public Pessoa Edit(Pessoa item)
        {
            return _repository.Edit(item);
        }

        public List<Pessoa> FindAll()
        {
            return _repository.FindAll();
        }

        public Pessoa FindById(long id)
        {
            return _repository.FindById(id);
        }
    }
}

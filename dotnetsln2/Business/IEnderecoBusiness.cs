using dotnetsln2.Models;
using System.Collections.Generic;

namespace dotnetsln2.Business
{
    public interface IEnderecoBusiness
    {
        public Endereco Create(Endereco item);
        public void Delete(long id);
        public Endereco Edit(Endereco item);
        public List<Endereco> FindAll();
        public Endereco FindById(long id);
    }
}

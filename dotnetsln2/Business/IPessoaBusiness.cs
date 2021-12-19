using dotnetsln2.Models;
using System.Collections.Generic;

namespace dotnetsln2.Business
{
    public interface IPessoaBusiness
    {
        public Pessoa Create(Pessoa item);
        public void Delete(long id);
        public Pessoa Edit(Pessoa item);
        public List<Pessoa> FindAll();
        public Pessoa FindById(long id);
    }
}

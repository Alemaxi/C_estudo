using dotnetsln2.Data.Converter.Contract;
using dotnetsln2.Data.VO;
using dotnetsln2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetsln2.Data.Converter.Implementations
{
    public class PessoaConverter : IParser<Pessoa, PessoaVO>, IParser<PessoaVO, Pessoa>
    {
        public Pessoa Parse(PessoaVO origin)
        {
            return new Pessoa()
            {
                Id = origin.Id,
                Idade = origin.Idade,
                Nome = origin.Nome
            };
        }


        public PessoaVO Parse(Pessoa origin)
        {
            return new PessoaVO()
            {
                Id = origin.Id,
                Idade = origin.Idade,
                Nome = origin.Nome
            };
        }

        public List<Pessoa> Parse(List<PessoaVO> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PessoaVO> Parse(List<Pessoa> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}

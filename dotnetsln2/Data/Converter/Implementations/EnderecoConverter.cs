using dotnetsln2.Data.Converter.Contract;
using dotnetsln2.Data.VO;
using dotnetsln2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetsln2.Data.Converter.Implementations
{
    public class EnderecoConverter : IParser<Endereco, EnderecoVO>, IParser<EnderecoVO, Endereco>
    {
        public Endereco Parse(EnderecoVO origin)
        {
            return new Endereco()
            {
                Id = origin.Id,
                Cidade = origin.Cidade,
                Estado = origin.Estado,
                pessoaId = origin.pessoaId
            };
        }


        public EnderecoVO Parse(Endereco origin)
        {
            return new EnderecoVO()
            {
                Id = origin.Id,
                Cidade = origin.Cidade,
                Estado = origin.Estado,
                pessoaId = origin.pessoaId
            };
        }

        public List<Endereco> Parse(List<EnderecoVO> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<EnderecoVO> Parse(List<Endereco> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}

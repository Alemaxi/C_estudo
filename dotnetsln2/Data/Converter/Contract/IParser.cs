using System.Collections.Generic;

namespace dotnetsln2.Data.Converter.Contract
{
    interface IParser <O,D>
    {
        public D Parse(O origin);
        public List<D> Parse(List<O> origin);
    }
}

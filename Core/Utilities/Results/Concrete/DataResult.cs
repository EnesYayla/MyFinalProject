using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success, message) //base'e bu iki bilgiyi geçirmek demek,
                                                                                       //bu kodları tekrardan yazmamak demektir
        {
            Data = data;
        }
        public DataResult(T data, bool success) :base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}

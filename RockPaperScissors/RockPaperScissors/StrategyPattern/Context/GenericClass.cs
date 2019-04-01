using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.StrategyPattern.Context
{
    public class GenericClass<T>
    {
        private readonly T genericMemberValue;

        public GenericClass(T value)
        {
            genericMemberValue = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}",typeof(T).ToString(),genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}",typeof(T).ToString(),genericMemberValue);

            return genericMemberValue;
        }

        public T GenericProperty { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scram
{
    public abstract class JayOperator : IOperation, IOperationExeption
    {
        public void JayGo()
        {
            Console.WriteLine("Hallo");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class NonGenericClass
    {
        public void Method()
        {
        }

        public async Task MethodAsync()
        {
            await Task.Run(Method);
        }
    }
}

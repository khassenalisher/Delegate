using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDelegate
{
    class Operation
    {
        public delegate void DelegateMes(string message);
        DelegateMes del;
        public void RegDelegateMes(DelegateMes _del)
        {
            del = _del;
        }
        public Operation()
        { }

        public void Sum(int _a, int _b)
        {
            del((_a + _b).ToString());
        }
  }
}

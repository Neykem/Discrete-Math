using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Math
{
    class FunctionViewModel
    {
        public FunctionViewModel(string name, int n1, int n2)
    {
        this.Name = name;
        this.N1 = n1;
        this.N2 = n2;
    }
    public string Name { get; set; }
    public int N1 { get; set; }
    public int N2 { get; set; }
}
}

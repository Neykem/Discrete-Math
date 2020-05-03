using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Math
{
    interface IBooleanFunc
    {
        TruthTable CalculationTruthTable(BooleanFunction booleanFunction);
        string CalculationPDNF(TruthTable truthTable);
        string CalculationPSNF(TruthTable truthTable);
    }
}

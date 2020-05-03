
namespace Discrete_Math
{
    interface IBooleanFunc
    {
        TruthTable CalculationTruthTable(BooleanFunction booleanFunction);
        TruthTable CalculationPDNF(TruthTable truthTable, int index_row);
        TruthTable CalculationPSNF(TruthTable truthTable, int index_row);
    }
}

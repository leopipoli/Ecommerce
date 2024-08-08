using System.ComponentModel;

namespace Domain.ValueObjects
{
    public enum TypeOperation
    {
        [Description("Venda")]
        Venda = 1,
        [Description("Troca")]
        Troca = 2,
        [Description("Desejo")]
        Desejo = 3
    }
}

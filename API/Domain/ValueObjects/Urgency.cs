using System.ComponentModel;

namespace Domain.ValueObjects
{
    public enum Urgency
    {
        [Description("Baixa")]
        Baixa = 1,
        [Description("Média")]
        Media = 2,
        [Description("Alta")]
        Alta = 3
            
        //    ,     
        //[Description("Data")]
        //Desejo = 4
    }
}

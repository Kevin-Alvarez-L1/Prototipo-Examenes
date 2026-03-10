using System;
using System.Collections.Generic;
using System.Text;


namespace PatronPrototipo
{
    public class ContabilidadPrototype : ExamenPrototype
    {
        public override ExamenPrototype Clone()
        {
            return (ContabilidadPrototype)this.MemberwiseClone();
        }
        public override string VerExamen()
        {
            return $"docente {_docente} grupo {_grupo} salon {_salon} tipo {_tipo}";
        }
    }
}

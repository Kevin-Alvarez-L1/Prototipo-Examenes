using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPrototipo
{
    public class PatronesPrototype : ExamenPrototype
    {
        public override ExamenPrototype Clone()
        {
            return (PatronesPrototype)this.MemberwiseClone();
        }
        public override string VerExamen()
        {
            return $"docente {_docente} grupo {_grupo} salon {_salon} tipo {_tipo}";
        }
    }
}

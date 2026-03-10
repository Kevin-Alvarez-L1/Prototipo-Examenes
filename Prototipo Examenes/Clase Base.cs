using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPrototipo
{
    public abstract class ExamenPrototype
    {
        protected string _docente;
        protected string _grupo;
        protected string _salon;
        protected string _tipo;
        public string Docente { set => _docente = value; }
        public string Grupo { set => _grupo = value; }

        public string Salon { set => _salon = value; }

        public string Tipo { set => _tipo = value; }
        public abstract ExamenPrototype Clone();
        public abstract string VerExamen();
    }
}

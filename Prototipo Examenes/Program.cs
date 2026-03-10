using System;

namespace PatronPrototipo
{
    class program
    {
        static void Main(string[] args)
        {
            //1
            ExamenPrototype patrones = new PatronesPrototype();
            ExamenPrototype Lenguajes = new LenguajesPrototype();
            ExamenPrototype Simulacion = new SimulacionPrototype();
            ExamenPrototype Quimica = new QuimicaPrototype();
            ExamenPrototype Informatica = new InformaticaPrototype();
            ExamenPrototype Matematicas = new MatematicasPrototype();
            ExamenPrototype Circuitos = new CircuitosPrototype();
            ExamenPrototype Contabilidad = new ContabilidadPrototype();

            //2
            //
            ExamenPrototype ExamenPatrones = patrones.Clone();
            ExamenPatrones.Grupo = "Matutino";
            ExamenPatrones.Docente = "Gerardo";
            ExamenPatrones.Salon = "9301";
            ExamenPatrones.Tipo = "Precencial";
            Console.WriteLine(ExamenPatrones.VerExamen());

            ExamenPrototype ExamenLenguajes = Lenguajes.Clone();
            ExamenLenguajes.Grupo = "Vespertino";
            ExamenLenguajes.Docente = "Jonathan";
            ExamenLenguajes.Salon = "9302";
            ExamenLenguajes.Tipo = "Precencial";
            Console.WriteLine(ExamenLenguajes.VerExamen());

            ExamenPrototype ExamenSimulacion = Simulacion.Clone();
            ExamenSimulacion.Grupo = "Matutino";
            ExamenSimulacion.Docente = "Jose";
            ExamenSimulacion.Salon = "9203";
            ExamenSimulacion.Tipo = "Virtual";
            Console.WriteLine(ExamenSimulacion.VerExamen());

            ExamenPrototype ExamenQuimica = Quimica.Clone();
            ExamenQuimica.Grupo = "Matutino";
            ExamenQuimica.Docente = "Katerine";
            ExamenQuimica.Salon = "501";
            ExamenQuimica.Tipo = "Virtual";
            Console.WriteLine(ExamenQuimica.VerExamen());

            ExamenPrototype ExamenInformatica = Informatica.Clone();
            ExamenInformatica.Grupo = "Verpertino";
            ExamenInformatica.Docente = "Susana";
            ExamenInformatica.Salon = "304";
            ExamenInformatica.Tipo = "Precencial";
            Console.WriteLine(ExamenInformatica.VerExamen());

            ExamenPrototype ExamenMatematicas = Matematicas.Clone();
            ExamenMatematicas.Grupo = "Matutino";
            ExamenMatematicas.Docente = "Abigail";
            ExamenMatematicas.Salon = "9401";
            ExamenMatematicas.Tipo = "Precencial";
            Console.WriteLine(ExamenMatematicas .VerExamen());

            ExamenPrototype ExamenCircuitos = Circuitos.Clone();
            ExamenCircuitos.Grupo = "Matutino";
            ExamenCircuitos.Docente = "Armando";
            ExamenCircuitos.Salon = "9305";
            ExamenCircuitos.Tipo = "Virtual";
            Console.WriteLine(ExamenCircuitos.VerExamen());

            ExamenPrototype ExamenContabilidad = Contabilidad.Clone();
            ExamenContabilidad.Grupo = "Vespertino";
            ExamenContabilidad.Docente = "Miguel";
            ExamenContabilidad.Salon = "706";
            ExamenContabilidad.Tipo = "Precencial";
            Console.WriteLine(ExamenContabilidad.VerExamen());

            Console.ReadKey();
        }
    }
}
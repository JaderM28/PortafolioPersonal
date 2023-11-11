namespace PortafolioPersonal.Models
{
    public class HomeIndex
    {
        public InformacionPersonal DatosPersona { get; set; }
        public IEnumerable<InformacionProyectos> Proyectos { get; set; }
    }
}

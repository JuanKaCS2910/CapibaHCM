using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capiba.HCM.Shared.DTOs
{
    public enum ModoInstalacionEnumDTO
    {
        cloud = 1, onpremise = 2
    }

    public class ConfiguracionInstanciaDTO
    {
        public int IdUsuarioGeneral { get; set; }
        public int IdInstalacion { get; set; }
        public ModoInstalacionEnumDTO ModoInstalacion { get; set; }
        public string BbddString { get; set; }
        public string BbddStringCifrado { get; set; }
        public string Login { get; set; }
        public int idRol { get; set; }
        public int? IdEmpleado { get; set; }
        public bool Master { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresaMovil { get; set; }
        public string FotoEmpleado { get; set; }
        public List<MenuViewDTO> menuSeguridad { get; set; }
        public string guidUsuario { get; set; }
    }

    public class MenuViewDTO
    {
        public int IdMenu { get; set; }
        public int? IdPadre { get; set; }
        public string Nombre { get; set; }
        public string Controlador { get; set; }
        public string Accion { get; set; }
        public string Icono { get; set; }
        public bool Visible { get; set; }
        public int Orden { get; set; }
        public bool DashBoard { get; set; }
        public int IdModulo { get; set; }
        public string Idioma { get; set; }
        public string Creacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Modificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}

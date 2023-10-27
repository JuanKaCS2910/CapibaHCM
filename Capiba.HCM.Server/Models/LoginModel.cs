using Capiba.HCM.Server.Utilitarios;
using Capiba.HCM.Shared.DTOs;

namespace Capiba.HCM.Server.Models
{
    

    public class LoginModel
    {
       
        public ConfiguracionInstanciaDTO GetUsuarioGlobal(string login, string password, bool hash = true)
        {
            var pwd = password;

            if (hash)
                pwd = SeguridadUtilitario.GetSHA1(password);

            /*
            var us = dbContext.UsuarioGeneral.FirstOrDefault(o => o.Login == login && o.Password == pwd);
            if (us == null)
                return null;

            var instancia = dbContext.Instalacion.FirstOrDefault(o => o.IdInstalacion == us.IdInstalacion);
            if (instancia == null)
                return null;
            var bbdd = dbContext.Servidor.FirstOrDefault(o => o.IdServidor == instancia.IdServidor);
            if (bbdd == null)
                return null;

            var cadenaBbdd = ConnectionStringExtension.MakeCadena(bbdd.Url,
                SeguridadUtilitario.Descifrar(bbdd.Usuario), SeguridadUtilitario.Descifrar(bbdd.Password),
                instancia.Bbdd);
            var conf = new ConfiguracionInstancia
            {
                ModoInstalacion = (ModoInstalacionEnum)instancia.IdTipoInstalacion,
                Login = us.Login,
                BbddString = cadenaBbdd,
                IdInstalacion = instancia.IdInstalacion,
                BbddStringCifrado = SeguridadUtilitario.Cifrar(cadenaBbdd),
                //user = new Usuario { IdUsuario = us.IdUsuarioGeneral }
                IdUsuarioGeneral = us.IdUsuarioGeneral
            };
*/

            var conf = new ConfiguracionInstanciaDTO();

            return conf;
        }

    }

    
}

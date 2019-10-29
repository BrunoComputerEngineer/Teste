using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLivreSeleniumTest.Domain
{
    public class Usuario
    {

        public string Login { get; set; }
        public string Password { get; set; }


        public Usuario GetUsuario()
        {
            EnvironmentData environment = new EnvironmentData().GetEnvironmentData();

            var reader = new StreamReader(File.OpenRead(new DirectoryInfo(new System.Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath).Parent.Parent.Parent.FullName + Path.Combine(@"\Data\Usuario.csv")));
            Dictionary<string, string> userDic = new Dictionary<string, string>();

            var header = reader.ReadLine().Split(';');
            var line = reader.ReadLine().Split(';');

            for (int i = 0; i < line.Length; i++)
            {
                userDic.Add(header[i], line[i]);
            }

            Usuario usuario = new Usuario();

            usuario.Login = userDic["Login"];
            usuario.Password = userDic["Password"];

            return usuario;
        }
    }
}

using System.Data.Entity;

namespace ElsasCharms.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var usuario1 = new Usuario();
            usuario1.Id = 1;
            usuario1.Nombre = "Seberiano";
            usuario1.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();
            usuario2.Id = 2;
            usuario2.Nombre = "Admin";
            usuario2.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(usuario2);

            base.Seed(contexto);
        }
    }

}
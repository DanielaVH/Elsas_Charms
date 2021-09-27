using System.Data.Entity;

namespace ElsasCharms.BL
{
    internal class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Anillo de Plata liso";
            producto1.Precio = 250;
            contexto.Productos.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Anillo de Plata decorado dama";
            producto2.Precio = 350;
            contexto.Productos.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Anillo de Plata decorado caballero";
            producto3.Precio = 350;
            contexto.Productos.Add(producto3);

            base.Seed(contexto);
        }
    }

}
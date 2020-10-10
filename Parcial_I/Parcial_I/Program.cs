using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;

namespace Parcial_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Consultar();

            static void Borrar()
            {
                var ctx = new TareasDbContext();
                var usuario = ctx.Usuarios.Where(i => i.Id == 1).Single();
                ctx.Usuarios.Remove(usuario);
                ctx.SaveChanges();
            }

            static void Actualizar()
            {
                var ctx = new TareasDbContext();
                var lista = ctx.Usuarios.Where(i => i.Id == 1).ToList();
                lista[0].Usuario = "prueba";
                ctx.SaveChanges();
            }


            static void Consultar()
            {
                var ctx = new TareasDbContext();

                var lista = ctx.Usuarios.ToList();
                foreach(var item in lista)
                {
                    Console.WriteLine($"Nombre: {item.Usuario}");
                }

            }

            static void Insertar()
            {
                var ctx = new TareasDbContext();

                ctx.Usuarios.Add(new Usuarios
                {
                    Usuario = "admin",
                    Clave = "admin"
                });

                ctx.SaveChanges();
            }
        }
    }
}

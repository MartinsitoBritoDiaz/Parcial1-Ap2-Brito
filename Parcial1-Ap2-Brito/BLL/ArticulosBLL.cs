using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Parcial1_Ap2_Brito.DAL;
using Parcial1_Ap2_Brito.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Brito.BLL
{
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos articulo)
        {
            if (!Existe(articulo.articuloId))
                return Insertar(articulo);
            else
                return Modificar(articulo);
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Articulo.Any(a => a.articuloId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool Insertar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            
            try
            {
                if(articulo.valorInventario == 0)
                {
                    articulo.valorInventario = (articulo.costo * articulo.existencia);
                }

                contexto.Articulo.Add(articulo);
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            
            return paso;
        }

        public static bool Modificar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (articulo.valorInventario == 0)
                {
                    articulo.valorInventario = (articulo.costo * articulo.existencia);
                }

                contexto.Entry(articulo).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Articulos articulo;

            try
            {
                articulo = contexto.Articulo.Find(id);

                if(articulo != null)
                {
                    contexto.Articulo.Remove(articulo);
                    paso = (contexto.SaveChanges() > 0);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulo;

            try
            {
                articulo = contexto.Articulo.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return articulo;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos , bool>> criterio)
        {
            List<Articulos> listaArticulos = new List<Articulos>();
            Contexto contexto = new Contexto();

            try
            {
                listaArticulos = contexto.Articulo.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return listaArticulos;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_Ap2_Brito.BLL;
using Parcial1_Ap2_Brito.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_Ap2_Brito.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
           bool paso = false;
            Articulos articulo = new Articulos();

            articulo.articuloId = 0;
            articulo.descripcion = "Moviles";
            articulo.existencia = 45;
            articulo.costo = 45;
            articulo.valorInventario = 2025;

            paso = ArticulosBLL.Guardar(articulo);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;

            paso = ArticulosBLL.Existe(1);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso = false;
            Articulos articulo = new Articulos();

            articulo.articuloId = 0;
            articulo.descripcion = "Moviles";
            articulo.existencia = 45;
            articulo.costo = 45;
            articulo.valorInventario = 2025;

            paso = ArticulosBLL.Insertar(articulo);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Articulos articulo = new Articulos();

            articulo.articuloId = 1;
            articulo.descripcion = "Moviles";
            articulo.existencia = 45;
            articulo.costo = 45;
            articulo.valorInventario = 2025;

            paso = ArticulosBLL.Guardar(articulo);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = ArticulosBLL.Eliminar(1);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;

            var articulo = ArticulosBLL.Buscar(1);

            if (articulo != null)
                paso = true;

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}
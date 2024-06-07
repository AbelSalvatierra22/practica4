using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practica4.Models;

namespace practica4.Service
{
    public class Productos
    {
        public List<Producto> getTrendingProductos() {
            List<Producto> result = new List<Producto>
            {
         new Producto { ProductoId = 1, NombreProducto = "Leche Gloria" },
        new Producto { ProductoId = 2, NombreProducto = "Leche Pura Vida" },
        new Producto { ProductoId = 3, NombreProducto = "Leche Laive" },
        new Producto { ProductoId = 4, NombreProducto = "leche Bonlé" },
        new Producto { ProductoId = 5, NombreProducto = "Leche Nestlé" },
        new Producto { ProductoId = 6, NombreProducto = "Leche Parmalat" },
        new Producto { ProductoId = 7, NombreProducto = "Leche Sullana" },
        new Producto { ProductoId = 8, NombreProducto = "Leche Yoilet" },
        new Producto { ProductoId = 9, NombreProducto = "Leche La Cremosita" },
        
            };

            return result;
        }
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
        new Producto { ProductoId = 1, NombreProducto = "Leche Gloria" },
        new Producto { ProductoId = 2, NombreProducto = "Leche Pura Vida" },
        new Producto { ProductoId = 3, NombreProducto = "Leche Laive" },
        new Producto { ProductoId = 4, NombreProducto = "leche Bonlé" },
        new Producto { ProductoId = 5, NombreProducto = "Leche Nestlé" },
        new Producto { ProductoId = 6, NombreProducto = "Leche Parmalat" },
        new Producto { ProductoId = 7, NombreProducto = "Leche Sullana" },
        new Producto { ProductoId = 8, NombreProducto = "Leche Yoilet" },
        new Producto { ProductoId = 9, NombreProducto = "Leche La Cremosita" },
        
        
        
            };
            return result;
        }


    }
}
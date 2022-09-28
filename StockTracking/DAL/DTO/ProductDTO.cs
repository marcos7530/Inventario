using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DTO
{
    public class ProductDTO
    {
        public List<ProductDetailDTO> Products { get; set; }

        //lo de abajo es para los combo boxes de categorias
        public List<CategoryDetailDTO> Categories { get; set; }
    }
}

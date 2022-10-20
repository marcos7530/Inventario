using StockTracking.DAL.DAO;
using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.BLL
{
    class SalesBLL : IBLL<SalesDetailDTO, SalesDTO>
    {
        SalesDAO salesdao =new SalesDAO();
        ProductDAO productdao = new ProductDAO();
        CategoryDAO categorydao = new CategoryDAO();
        CustomerDAO customerdao = new CustomerDAO();
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool GetBack(SalesDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SalesDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public SalesDTO Select()
        {
            SalesDTO dto = new SalesDTO();

            dto.Products = productdao.Select();
            dto.Customers = customerdao.Select();
            dto.Categories = categorydao.Select();
            //dto.Sales = salesdao.Select();

            return dto;
        }

        public bool Update(SalesDetailDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}

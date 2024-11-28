using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2.Controllers
{
    public class ProductSupplierController
    {
        private TravelExpertsContext context = new();

        public List<ProductSupplierViewModel> GetAllProductsAndSuppliers()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var productSuppliers = db.ProductsSuppliers
                    .Select(ps => new ProductSupplierViewModel
                    {
                        ProductSupplierId = ps.ProductSupplierId,
                        ProductId = ps.Product.ProductId, 
                        SupplierId = ps.Supplier.SupplierId,
                        SupName = ps.Supplier.SupName,
                        ProdName = ps.Product.ProdName
                    }).ToList();

                return productSuppliers;
            }
        }

        public void deleteProductSupplier(ProductSupplierViewModel psToDelete)
        {
            
        }

        public ProductSupplierViewModel ConvertToProductSupplierModel(DataGridViewRow row)
        {
            return new ProductSupplierViewModel
            {
                ProductSupplierId = Convert.ToInt32(row.Cells["ProductSupplierId"].Value),
                ProductId = Convert.ToInt32(row.Cells["ProductId"].Value),
                SupplierId = Convert.ToInt32(row.Cells["SupplierId"].Value),
                SupName = row.Cells["SupName"].Value.ToString(),
                ProdName = row.Cells["ProdName"].Value.ToString()
            };
        }
    }
}

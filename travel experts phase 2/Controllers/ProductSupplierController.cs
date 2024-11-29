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
            var productSuppliers = context.ProductsSuppliers
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

        public void AddProductSupplier(ProductSupplierViewModel prodSupplierToAdd)
        {
            var productSupplier = new ProductsSupplier
            {
                ProductId = prodSupplierToAdd.ProductId,
                SupplierId = prodSupplierToAdd.SupplierId
                //SupName = prodSupplierToAdd.SupName,
                //ProdName = prodSupplierToAdd.ProdName
            };

            context.ProductsSuppliers.Add(productSupplier);
            context.SaveChanges();

        }

        public List<ProductSupplierViewModel> GetAllProducts()
        {
            return context.Products.Select(ps => new ProductSupplierViewModel
            {
                ProdName = ps.ProdName,
                ProductId = ps.ProductId
            }).ToList();
        }

        public List<ProductSupplierViewModel> GetAllSuppliers()
        {
            return context.ProductsSuppliers.Select(s => new ProductSupplierViewModel
            {
                SupplierId = s.Supplier.SupplierId,
                SupName = s.Supplier.SupName,
            }).ToList();
        }

        public void UpdateProductSupplier(ProductSupplierViewModel updatedProductSupplierInfo)
        {
            var detailsOfProductSupplier = context.ProductsSuppliers.FirstOrDefault(ps =>
                ps.ProductSupplierId == updatedProductSupplierInfo.ProductSupplierId);
            detailsOfProductSupplier.ProductId = updatedProductSupplierInfo.ProductId;
            detailsOfProductSupplier.SupplierId = updatedProductSupplierInfo.SupplierId;

            context.ProductsSuppliers.Update(detailsOfProductSupplier);
            context.SaveChanges();
        }
    }
}

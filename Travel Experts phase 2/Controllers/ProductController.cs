using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2.Controllers
{
    public class ProductController
    {

        private TravelExpertsContext context = new();

        public List<ProductViewModel> GetAllProducts()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var products = db.Products.Select(product => new ProductViewModel
                {
                    Id = product.ProductId,
                    ProductName = product.ProdName

                }).ToList();

                return products;
            }
        }

        public void AddProduct(ProductViewModel productViewModel)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var product = new Product
                {
                    ProdName = productViewModel.ProductName,
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void deleteProduct(Product productToBeDeleted)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                if (productToBeDeleted != null)
                {
                    context.Products.Remove(productToBeDeleted);
                    context.SaveChanges();
                }
            }
        }

        public void UpdateProduct(ProductViewModel productViewModel)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var product = new Product
                {
                    ProductId = productViewModel.Id,
                    ProdName = productViewModel.ProductName,
                };
                context.Products.Update(product);
                context.SaveChanges();
            }
        }



        public Product ConvertToProductFromDataGrid(DataGridViewRow row)
        {
            return new Product
            {
                ProductId = Convert.ToInt32(row.Cells["Id"].Value),
                ProdName = row.Cells["ProductName"].Value.ToString(),
            };
        }

        public ProductViewModel ConvertToProductViewModel(DataGridViewRow row)
        {
            return new ProductViewModel
            {
                Id = Convert.ToInt32(row.Cells["Id"].Value),
                ProductName = row.Cells["ProductName"].Value.ToString(),
            };
        }
    }
}

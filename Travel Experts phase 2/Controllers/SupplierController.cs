using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2.Controllers
{
    public class SupplierController
    {
        //using (travel_experts_phase_2 )
        private TravelExpertsContext context = new();

        public List<SuppliersViewModel> GetAllSuppliers()

        {

            using (TravelExpertsContext db = new TravelExpertsContext())

            {

                var supplier = db.Suppliers.Select(supplier => new SuppliersViewModel

                {

                    SupplierId = supplier.SupplierId,

                    SupplierName = supplier.SupName

                }).ToList();

                return supplier;

            }

        }

        public void AddSupplier(SuppliersViewModel supplierViewModel)

        {

            var supplier = new Supplier
            {

                SupName = supplierViewModel.SupplierName

            };

            context.Suppliers.Add(supplier);

            context.SaveChanges();
        }

        public void deleteSupplier(Supplier supplierToBeDeleted)
        {

            if (supplierToBeDeleted != null)
            {
                context.Suppliers.Remove(supplierToBeDeleted);
                context.SaveChanges();

            }

        }

        public void UpdateSupplier(SuppliersViewModel supplierViewModel)
        {
            var supplier = new Supplier

            {

                SupplierId = supplierViewModel.SupplierId,

                SupName = supplierViewModel.SupplierName,

            };

            context.Suppliers.Update(supplier);

            context.SaveChanges();

        }


        public Supplier ConvertToSupplierFromDataGrid(DataGridViewRow row)
        {
            return new Supplier
            {
                SupplierId = Convert.ToInt32(row.Cells["SupplierId"].Value),

                SupName = row.Cells["SupName"].Value.ToString()

            };

        }

        public SuppliersViewModel ConvertToSuppliersViewModel(DataGridViewRow row)
        {

            return new SuppliersViewModel

            {

                SupplierId = Convert.ToInt32(row.Cells["SupplierId"].Value),

                SupplierName = row.Cells["SupName"].Value.ToString(),
            };

        }


    }
}

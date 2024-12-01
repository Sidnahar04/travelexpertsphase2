using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2.Controllers
{
    public class PackageController
    {

        private TravelExpertsContext context = new();

        public List<PackageViewModel> GetAllPackages()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var packages = db.Packages.Select(package => new PackageViewModel
                {
                    PackageId = package.PackageId,
                    PkgName = package.PkgName,
                    PkgStartDate = package.PkgStartDate,
                    PkgEndDate = package.PkgEndDate,
                    PkgDesc = package.PkgDesc,
                    PkgBasePrice = Math.Round(package.PkgBasePrice, 2),
                    PkgAgencyCommission = Math.Round((decimal)package.PkgAgencyCommission, 2)
                }).ToList();

                return packages;  
            }
        }

        public void AddPackage(PackageViewModel packageViewModel)
        {
            var package = new Package
            {
                PkgName = packageViewModel.PkgName,
                PkgStartDate = packageViewModel.PkgStartDate,
                PkgEndDate = packageViewModel.PkgEndDate,
                PkgDesc = packageViewModel.PkgDesc,
                //PackageId=packageViewModel.PackageID,
                PkgBasePrice = (decimal)packageViewModel.PkgBasePrice,
                PkgAgencyCommission = (decimal)packageViewModel.PkgAgencyCommission
            };
            context.Packages.Add(package);
            context.SaveChanges();
        }

        public void deletePackage(Package packageToBeDeleted)
        {
            if (packageToBeDeleted != null)
            {
                context.Packages.Remove(packageToBeDeleted);
                context.SaveChanges();
            }
        }

        public void UpdatePackage(PackageViewModel packageViewModel)
        {
            var package = new Package
            {
                PkgName = packageViewModel.PkgName,
                PkgStartDate = packageViewModel.PkgStartDate,
                PkgEndDate = packageViewModel.PkgEndDate,
                PkgDesc = packageViewModel.PkgDesc,
                PackageId = packageViewModel.PackageId,
                PkgBasePrice = (decimal)packageViewModel.PkgBasePrice,
                PkgAgencyCommission = (decimal)packageViewModel.PkgAgencyCommission
            };
            context.Packages.Update(package);
            context.SaveChanges();
        }



        public Package ConvertToPackageForDataGrid(DataGridViewRow row)
        {
            return new Package
            {
                PackageId = Convert.ToInt32(row.Cells["PackageId"].Value),
                PkgName = row.Cells["PkgName"].Value.ToString(),
                PkgStartDate = Convert.ToDateTime(row.Cells["PkgStartDate"].Value),
                PkgEndDate = Convert.ToDateTime(row.Cells["PkgEndDate"].Value),
                PkgDesc = row.Cells["PkgDesc"].Value.ToString(),
                PkgBasePrice = Convert.ToDecimal(row.Cells["PkgBasePrice"].Value),
                PkgAgencyCommission = Convert.ToDecimal(row.Cells["PkgAgencyCommission"].Value)
            };
        }

        public PackageViewModel ConvertToPackageModel(DataGridViewRow row)
        {
            return new PackageViewModel
            {
                PackageId = Convert.ToInt32(row.Cells["PackageId"].Value),
                PkgName = row.Cells["PkgName"].Value.ToString(),
                PkgStartDate = Convert.ToDateTime(row.Cells["PkgStartDate"].Value),
                PkgEndDate = Convert.ToDateTime(row.Cells["PkgEndDate"].Value),
                PkgDesc = row.Cells["PkgDesc"].Value.ToString(),
                PkgBasePrice = Convert.ToDecimal(row.Cells["PkgBasePrice"].Value),
                PkgAgencyCommission = Convert.ToDecimal(row.Cells["PkgAgencyCommission"].Value)
            };
        }
    }
}

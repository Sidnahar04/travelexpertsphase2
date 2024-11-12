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
       

        public List<PackageViewModel> GetAllPackages()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var packages = db.Packages.Select(package => new PackageViewModel
                {
                    PkgName = package.PkgName,
                    PkgStartDate = package.PkgStartDate,
                    PkgEndDate = package.PkgEndDate,
                    PkgDesc = package.PkgDesc,
                    PkgBasePrice = package.PkgBasePrice,
                    PkgAgencyCommission = package.PkgAgencyCommission
                }).ToList();

                return packages;
            }
        }
    }
}

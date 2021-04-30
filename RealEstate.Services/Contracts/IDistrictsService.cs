using RealEstates.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstates.Services.Contracts
{
    public interface IDistrictsService
    {
        IEnumerable<DistrictViewModel> GetTopDistrictsByAveragePrice(int count = 10);

        IEnumerable<DistrictViewModel> GetTopDistrictsByNumberOfProperties(int count = 10);
    }
}

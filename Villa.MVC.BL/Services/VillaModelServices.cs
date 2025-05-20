using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.MVC.BL.ViewModels;
using Villa.MVC.DAL.Contexts;
using Villa.MVC.DAL.Models;

namespace Villa.MVC.BL.Services;

public class VillaModelServices
{
    private readonly AppDbContext _context;
    public VillaModelServices()
    {
        _context = new AppDbContext();
    }

    public void Create(VillaModelCreateVM villaModelCreateVM)
    {
        VillaModel villaModel = new VillaModel();
        villaModel.Name = villaModelCreateVM.Name;
        villaModel.Address = villaModelCreateVM.Address;
        villaModel.Price = villaModelCreateVM.Price;
        villaModel.Bedrooms = villaModelCreateVM.Bedrooms;
        villaModel.Bathrooms = villaModelCreateVM.Bedrooms;
        villaModel.Area = villaModelCreateVM.Area;
        villaModel.Floor = villaModelCreateVM.Floor;
        villaModel.Parking = villaModelCreateVM.Parking; 
        //File Upload
        
    }
        
    
}
       



using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.MVC.BL.ViewModels;

public class VillaModelCreateVM
{
    public string Name { get; set; }
    public string Address { get; set; }
    public decimal Price { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Area { get; set; }
    public int Floor { get; set; }
    public int Parking { get; set; }
    public IFormFile Image { get; set; }

}

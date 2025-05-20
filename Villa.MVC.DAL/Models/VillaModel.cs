namespace Villa.MVC.DAL.Models;

public class VillaModel :BaseModel
{
    public string Name { get; set; }
    public string Address { get; set; }
    public decimal Price { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Area { get; set; }
    public int Floor { get; set; }
    public int Parking { get; set; }
    public string ImgPath { get; set; }

}

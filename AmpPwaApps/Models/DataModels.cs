using System.Collections.Generic;

namespace AmpPwaApps.Models
{
    public class Brand
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SelectListValue { get; set; }
        public bool Selected { get; set; }
        public string Identifier { get; set; }
    }

    public class Model
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SelectListValue { get; set; }
        public bool Selected { get; set; }
        public string Identifier { get; set; }
    }

    public class CarModel
    {
        public string Id { get; set; }
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public string SmallLabel { get; set; }
        public string RegularLabel { get; set; }
        public bool DisplayLimitedStock { get; set; }
        public string LimitedStockLabel { get; set; }
        public object LimitedStockTermsAndConditions { get; set; }
        public string Title { get; set; }
    }

    public class Brand2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SelectListValue { get; set; }
        public bool Selected { get; set; }
        public string Identifier { get; set; }
    }

    public class Model2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SelectListValue { get; set; }
        public bool Selected { get; set; }
        public string Identifier { get; set; }
    }

    public class Type
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SelectListValue { get; set; }
        public bool Selected { get; set; }
        public string Identifier { get; set; }
    }

    public class FuelType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SelectListValue { get; set; }
        public bool Selected { get; set; }
        public string Identifier { get; set; }
    }

    public class Transmission
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SelectListValue { get; set; }
        public bool Selected { get; set; }
        public string Identifier { get; set; }
    }

    public class Target
    {
        public string Id { get; set; }
        public string TargetName { get; set; }
    }

    public class Language
    {
        public string Name { get; set; }
    }

    public class SideShot
    {
        public string Alt { get; set; }
        public string Border { get; set; }
        public string Class { get; set; }
        public int Height { get; set; }
        public int HSpace { get; set; }
        public string Src { get; set; }
        public int VSpace { get; set; }
        public int Width { get; set; }
        public string MediaId { get; set; }
        public string Title { get; set; }
        public Language Language { get; set; }
    }

    public class Language2
    {
        public string Name { get; set; }
    }

    public class TypeShot
    {
        public string Alt { get; set; }
        public string Border { get; set; }
        public string Class { get; set; }
        public int Height { get; set; }
        public int HSpace { get; set; }
        public string Src { get; set; }
        public int VSpace { get; set; }
        public int Width { get; set; }
        public string MediaId { get; set; }
        public string Title { get; set; }
        public Language2 Language { get; set; }
    }

    public class Option
    {
        public int CalcId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string BLSName { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
        public bool Selected { get; set; }
        public double Price { get; set; }
        public string Identifier { get; set; }
    }

    public class StandardOption
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public object BLSName { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
    }

    public class Image
    {
        public string Url { get; set; }
        public string Alt { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
    }

    public class ImageFolder
    {
        public List<Image> Images { get; set; }
    }

    public class Colour
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ColourhexCode { get; set; }
        public string OrderCode { get; set; }
        public ImageFolder ImageFolder { get; set; }
        public double Price { get; set; }
        public bool Selected { get; set; }
    }

    public class Insurance
    {
        public string Id { get; set; }
        public int CalcId { get; set; }
        public string Label { get; set; }
        public string Information { get; set; }
        public bool Selected { get; set; }
        public bool Disabled { get; set; }
        public bool Mandatory { get; set; }
        public double Price { get; set; }
        public string Identifier { get; set; }
    }

    public class PolicyExcessOption
    {
        public string Id { get; set; }
        public int CalcId { get; set; }
        public string Label { get; set; }
        public string Information { get; set; }
        public bool Default { get; set; }
        public bool Selected { get; set; }
        public double Price { get; set; }
        public string Identifier { get; set; }
    }

    public class Car
    {
        public string Id { get; set; }
        public CarModel CarModel { get; set; }
        public string Title { get; set; }
        public Brand2 Brand { get; set; }
        public Model2 Model { get; set; }
        public Type Type { get; set; }
        public FuelType FuelType { get; set; }
        public Transmission Transmission { get; set; }
        public int NrOfPassengers { get; set; }
        public List<Target> Targets { get; set; }
        public SideShot SideShot { get; set; }
        public TypeShot TypeShot { get; set; }
        public List<Option> Options { get; set; }
        public List<StandardOption> StandardOptions { get; set; }
        public string SearchTitle { get; set; }
        public List<Colour> Colours { get; set; }
        public object ColoursImage { get; set; }
        public string BasedOn { get; set; }
        public string TechnicalSpecs { get; set; }
        public string Bhp { get; set; }
        public string Engine { get; set; }
        public string FuelConsumption { get; set; }
        public string Emission { get; set; }
        public string EnergyLabel { get; set; }
        public string SmallLabel { get; set; }
        public string RegularLabel { get; set; }
        public bool DisplayLimitedStock { get; set; }
        public string LimitedStockLabel { get; set; }
        public string LimitedStockTermsAndConditions { get; set; }
        public double Price { get; set; }
        public double LeaseOptionPrice { get; set; }
        public double AdditionalKmPrice { get; set; }
        public double LessKmPrice { get; set; }
        public string Link { get; set; }
        public List<Insurance> Insurances { get; set; }
        public List<PolicyExcessOption> PolicyExcessOptions { get; set; }
        public bool OnlineAfsluiten { get; set; }
        public string ServiceUrl { get; set; }
        public string OverviewUrl { get; set; }
        public string ConfigUrl { get; set; }
        public string TypeSelectionUrl { get; set; }
    }

}

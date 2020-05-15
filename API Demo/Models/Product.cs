using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using API_Demo.Models;

namespace API_Demo.Model
{
    public class Product
    {
        
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public ProductCategory Category { get; set; }
        public double Price { get; set; }
        public Promotion Promotion { get; set; }
        public int AmountTraded { get; set; }
        public IEnumerable<QandA> Question { get; set; }
        public string Image { get; set; }
    }

    public class QandA
    {
        [Key] public int Id { get; set; }
        
        public string Question { get; set; }
        public string Answer { get; set; }
    }


    public enum ProductCategory
    {
        Bathroom,
        BathAccessories,
        BathroomProducts,
        ShowerProducts,
        ToiletProducts,
        CarAndVehicleCare,
        CarCleaningProducts,
        WinterCare,
        CleaningAndLaundry,
        AirFreshener,
        BrushesAndBrooms,
        CleaningProducts,
        ClothesAirersAndAccessories,
        ClothingAndShoeCare,
        Ironing,
        MopsAndBuckets,
        Sponges,ClothsAndScourers,
        DecoratingAndDiy,
        Abrasives,
        AdhesiveTape,
        Adhesives,
        Cement,
        CurtainProducts,
        DiyAccessories,
        DecoratingProducts,
        ExteriorWoodcare,
        InteriorWoodcare,
        Ironmongery,
        LaddersAndSteps,
        Paint,
        PaintAccessories,
        Electrical,
        Batteries,
        DoorBell,
        ElectricalAccessories,
        Torches,
        ElectricalAppliances,
        ElectricalCookware,
        Fans,
        FoodPreparation,
        FoodProcessorsAndBlenders,
        Irons,
        Kettles,
        PersonalCare,
        RadiosAndHeadphones,
        Toasters,
        VacuumCleaners,
        Gardening,
        AllWeatherClocks,
        BirdandWildlifeCare,
        ChildrensGardening,
        Cleaners,
        GardenAccessories,
        GardenBagsAndCarriers,
        GardenLighting,
        GardenPowerToolAccessories,
        GrowingMedia,
        HandTools,
        Incinerators,
        LawnAndLawnCare,
        Netting,
        PlantFoodAndFertilisers,
        PlantProtection,
        PotsAndPlanters,
        PowerTools,
        RepellentsAndInsecticides,
        StructuresAndOrnaments,
        WateringProducts,
        WeedControl,
        Housewares,
        BinsAndLiners,
        Cutlery,
        Drinksware,
        FixturesAndFittings,
        FoodStorage,
        IndoorPestControl,
        Mats,
        MiscellaneousHousewares,
        Scissors,
        Security,
        ShoppingBasketsAndTrolleys,
        StepsAndStools,
        Storage,
        Textiles,
        WaterFiltration,
        WineAndDine,
        KitchenGadgetsAndCookware,
        Baking,
        Breakfast,
        ChoppingBoards,
        Condiments,
        Cookware,
        FoodWrap,
        Gadgets,
        Knives,
        NonElectricalKettles,
        Preserving,
        Scales,
        Leisure,
        BarbecuesAndAccessories,
        CampingAndOutdoor,
        GardenFurniture,
        Lighting,LanternsAndTorches,
        OutdoorGames,
        Travel,
        PetCare,
        PetAccessories,
        SpecialisedPetCleaning,
        PlumbingHeatingFireside,
        FiresideProducts,
        OilLampsAndAccessories,
        PlumbingProducts,
        Tools,
        Hammers,
        Saws,
        TapesAndRules
    }
}
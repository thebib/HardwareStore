using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using API_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace API_Demo.Model
{
    public class Product
    {
        public Product()
        {
            Questions = new List<Question>();
            Id = _idGenerator;
            _idGenerator++;
        }

        private static int _idGenerator = 1;
        
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public ProductCategory Category { get; set; }
        public double Price { get; set; }
        public Promotion Promotion { get; set; }
        public int AmountTraded { get; set; }
        public ICollection<Question> Questions { get; }
        public string Image { get; set; }

        public List<ShippingOption> ShippingOptions { get; set; }
    }


    public class Question
    {
        public Question()
        {
            Id = _idGenerator;
            DateAdded = DateTime.Now;
            _idGenerator++;
        }
        
        private static int _idGenerator = 1;

        public int Id { get; }
        public string Value { get; set; }
        
        public string Answer { get; set; }
        
        public DateTime DateAdded { get; set; }
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
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AmpPwaApps.Models
{
    public static class CarDealersDatabase
    {
        public static IEnumerable<string> CarDealers { get; set; }
        static CarDealersDatabase()
        {
            CarDealers = new List<string>
            {
              "Muntstad Utrecht",
              "Maas Autogroep Uithoorn",
              "De Waal Autogroep",
              "De Waal Gorinchem",
              "Vallei Auto Groep Veenendaal",
              "Van Beynum Autobedrijven",
              "Lexpoint",
              "M. de Koning Autobedrijven",
              "Van den Udenhout - Den Bosch",
              "Auto Flevo",
              "Martin Schilder Haarlem",
              "Wittebrug",
              "Wittebrug Forepark",
              "Van den Udenhout Oss",
              "Heron Auto",
              "Ames Autobedrijf B.V.",
              "Audi Centrum Rotterdam",
              "Zenna",
              "Audi Centrum Breda",
              "Hegeman Nijmegen",
              "Autohaas",
              "Audi Centrum Tilburg",
              "Wittebrug De Lier",
              "Martin Schilder Alkmaar",
              "Pouw Deventer",
              "Van den Udenhout Eindhoven",
              "Audi Centrum Roosendaal",
              "Audi Centrum Doetinchem",
              "Van Mossel Valkenswaard",
              "Pouw Zwolle",
              "Pouw Rijssen",
              "Van Mossel Weert",
              "Auto Arena",
              "Huiskes-Kokkeler Automobielbedrijven",
              "Auto Poppe Goes",
              "Autoland Van den Brug",
              "Bourguignon",
              "Century Autogroep",
              "Wealer",
              "Century Autogroep"
            };
        }
    }
}

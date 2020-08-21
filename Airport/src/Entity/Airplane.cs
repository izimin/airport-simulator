using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.src.Entity
{
    [Serializable]
    public class Airplane
    {
        public static int id = 0;
        public enum StatusAirplane
        {
            BOUGHT,
            INRENT,
            INLEASING,
            INMARKET
        };

        public int Id { get; set; }                   
        public string Model { get; set; }            // Модель самолета
        public int PriceToBuy { get; set; }          // Цена на покупку
        public int PriceToSell { get; set; }         // Цена на продажу
        public int PriceToRent { get; set; }         // Цена на аренду 
        public int PriceToLeasing { get; set; }      // Цена на лизинг
        public int Carrying { get; set; }            // Грузоподъемность
        public int PassengerСapacity { get; set; }   // Пассажировместимость
        public int Wear { get; set; }                // Износ
        public int FuelConsumption { get; set; }     // Расход топлива
        public int Speed { get; set; }               // Крейсерская скорость
        public int RangeFlight { get; set; }         // Дальность полета
        public StatusAirplane Status { get; set; }   // Статус - купленный, в аренде, в лизинге, в магазине
        public string Tenancy { get; set; }             // Срок аренды/лизинга
        public Image AirplaneImage { get; set; }
        public bool inShedule { get; set; }
        public string Location { get; set; }
        public DateTime? dtFinichFix { get; set; }
        public Airplane(string model, int priceToBuy, int priceToSell, int priceToRent, int priceToLeasing, 
            int carrying, int passengerСapacity, int wear, int fuelConsumption, int speed, int rangeFlight, Image airplaneImage, StatusAirplane status, string tenancy)
        {
            inShedule = false;
            Location = "Perm";
            Id = id++;
            Model = model.Split('(')[0].Trim() + " (" + Id + ")";
            PriceToBuy = priceToBuy;
            PriceToSell = priceToSell;
            PriceToRent = priceToRent;
            PriceToLeasing = priceToLeasing;
            Carrying = carrying;
            PassengerСapacity = passengerСapacity;
            Wear = wear;
            FuelConsumption = fuelConsumption;
            Speed = speed;
            RangeFlight = rangeFlight;
            AirplaneImage = airplaneImage;
            Status = status;
            Tenancy = tenancy;
            dtFinichFix = null;
        }
    }
}

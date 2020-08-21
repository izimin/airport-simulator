using System;
using System.Windows.Forms.VisualStyles;
using Airport.src.Entity;

namespace Airport.Entity
{
    [Serializable]
    class Flight
    {
        internal enum TypeFlieght
        {
            PASSENGER,
            CARGO,
            EMPTY
        }

        internal enum RegularityFlieght
        {
            REGULARITYTOFROM,
            REGULARITYTO,
            SINGLETO,
            SINGLETOFROM
        }

        public int Number { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DateAndTimeDeparture { get; set; }
        public DateTime DateAndTimeArrival { get; set; }
        public TypeFlieght Type { get; set; }
        public RegularityFlieght Regularity { get; set; }
        public int Distance { get; set; }
        public int Profit { get; set; }
        public int Forfeit { get; set; }
        public int Carrying { get; set; }            // Грузоподъемность
        public int PassengerСapacity { get; set; }   // Пассажировместимость
        public Airplane AirplaneFlight { get; set; }

        public Flight(int number, string @from, string to, DateTime dateAndTimeDeparture,
            DateTime dateAndTimeArrival, TypeFlieght type, RegularityFlieght regularity, int distance, int profit, 
            int forfeit, int carrying, int passengerСapacity)
        {
            Number = number;
            From = @from;
            To = to;
            DateAndTimeDeparture = dateAndTimeDeparture;
            DateAndTimeArrival = dateAndTimeArrival;
            Type = type;
            Regularity = regularity;
            Distance = distance;
            Profit = profit;
            Forfeit = forfeit;
            Carrying = carrying;
            PassengerСapacity = passengerСapacity;
        }
    }
}

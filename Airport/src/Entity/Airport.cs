using System;
using System.Collections.Generic;
using Airport.Entity;
using Airport.src.Entity;

namespace Airport
{
    [Serializable]
    class Airport
    {
        private double balance;

        private double fuel;

        private double fuelPrice;

        [field: NonSerialized]
        public delegate void BalanceEventHandler(BalanceEventArgs arg);

        [field: NonSerialized]
        public delegate void FuelEventHandler(FuelEventArgs arg);

        [field: NonSerialized]
        public delegate void FuelPriceEventHandler(FuelPriceEventArgs arg);

        [field: NonSerialized]
        public event BalanceEventHandler BalanceChanged;

        [field: NonSerialized]
        public event FuelEventHandler FuelChanged;

        [field: NonSerialized]
        public event FuelPriceEventHandler FuelPriceChanged;

        public List<Airplane> ListAirplanesToBuy { get; set; }
        public List<Airplane> ListAirplanes { get; set; }
        public List<Flight> ListFlights { get; set; }
        public List<Flight> ListShedule { get; set; }
        public int NumberFlight = 1;

        public Airport()
        {
            Balance = 10000000.0;
            Fuel = 1000.0;
            FuelPrice = 30.0;
            ListAirplanesToBuy = new List<Airplane>();
            ListAirplanes = new List<Airplane>();
            ListFlights = new List<Flight>();
            ListShedule = new List<Flight>();
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                balance = value;
                OnBalanceChange(value);
            }
        }

        public double Fuel
        {
            get { return fuel; }
            set
            {
                fuel = value;
                OnFuelChange(value);
            }
        }

        public double FuelPrice
        {
            get { return fuelPrice; }
            set
            {
                fuelPrice = value;
                OnFuelPriceChange(value);
            }
        }

        // Генерируем собтие при изменении баланса
        private void OnBalanceChange(double Balance)
        {
            BalanceChanged?.Invoke(new BalanceEventArgs(Balance));
        }

        private void OnFuelChange(double Fuel)
        {
            FuelChanged?.Invoke(new FuelEventArgs(Fuel));
        }

        private void OnFuelPriceChange(double FuelPrice)
        {
            FuelPriceChanged?.Invoke(new FuelPriceEventArgs(FuelPrice));
        }
    }

    public class BalanceEventArgs : EventArgs
    {
        public double SoundLevel { get; }

        public BalanceEventArgs(double soundLevel) 
        {
            this.SoundLevel = soundLevel;
        }
    }

    public class FuelEventArgs : EventArgs
    {
        public double SoundLevel { get; }

        public FuelEventArgs(double soundLevel)
        {
            this.SoundLevel = soundLevel;
        }
    }

    public class FuelPriceEventArgs : EventArgs
    {
        public double SoundLevel { get; }

        public FuelPriceEventArgs(double soundLevel)
        {
            this.SoundLevel = soundLevel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30012020
{
    class Car
    {
        // 0'lana bilen probeg
        private double _localKm;
        public double LocalKm
        {
            get
            {
                return _localKm;
            }
        }
        // 0'lanmayan probeg
        private double _globalKm;
        public double GlobalKm
        {
            get
            {
                return _globalKm;
            }
        }
        // hazirda bakda olan yanacaq miqdari
        private double _currentFuel;

        //Umumi bakin hecmi
        private double _fuelCapacity;

        // 100 km'e serf edilen yanacaq
        private double _fuelUsage;

        //bakdaki yanacaqla gedile bilecek mesafe
        private double _maxLimitKm;
        public double MaxLimit
        {
            get
            {
                return _maxLimitKm;
            }
        }

        /// <summary>
        ///  Constructora bakin hecmi ve 100 km'e ne qeder serf edeceyi miqdari gonderirik
        ///  ve Car yaradilanda uzerinde kapasitesinin 10%'i ile gelir
        /// </summary>
        public Car(double FuelCapacity, double FuelUsage)
        {
            _fuelCapacity = FuelCapacity;
            _fuelUsage = FuelUsage;

            _currentFuel = _fuelCapacity * 0.1;

            CalcMaxLimit();
        }

        // Max km'ni hesablayan metod
        private double CalcMaxLimit()
        {
            return _maxLimitKm = _currentFuel / _fuelUsage * 100;
        }

        public bool Drive(double km)
        {
            if(km > _maxLimitKm)
            {
                return false;
            }

            _localKm += km;
            _globalKm += km;

            _currentFuel -= km / 100 * _fuelUsage;
            CalcMaxLimit();
            return true;
        }

        public bool AddFuel(double litr)
        {
            if(_currentFuel + litr > _fuelCapacity)
            {
                return false;
            }

            _currentFuel += litr;

            CalcMaxLimit();
            return true;
        }
        // local km 0lanir
        public void ResetLocal()
        {
            _localKm = 0;
        }


        public double NeededFuel()
        {
            return _fuelCapacity - _currentFuel;
        }

    }
}

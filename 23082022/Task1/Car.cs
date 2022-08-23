using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private double _fuelcapacity;

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length > 2)
                    _brand = value;
            }
        }

        public string Model {
            get
            {
                return _model;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length>2)
                    _model = value;
            }
        
        
        }

        public double Fuelcapacity
        {
            get 
            {
                return _fuelcapacity;

            }
            set
            {
                if(value>=0 && value<=120)
                    _fuelcapacity = value;  
            }
        }

    }
}
    


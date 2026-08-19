using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal abstract class Shipment
    {
        #region Attributes
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        private static int TotalShipmentsCreated;
        #endregion

        #region Properties
        public DeliveryAddress Destination { get; set; }
        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tracking code cannot be null or empty.");
                }
                trackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Description cannot be null or empty.");
                }
                description = value;
            }
        }

        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Weight must be a positive value.");
                }
                weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Delivery fee cannot be negative.");
                }
                deliveryFee = value;
            }
        }

        public abstract decimal EstimatedCost();
        #endregion

        #region Constructor
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);

        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

        }
        #endregion

        #region Methods
        public void UpdateDeliveryFee(decimal newFee)
        {
            if(newFee>=0)
            DeliveryFee = newFee;

            else 
                throw new ArgumentOutOfRangeException("Delivery fee must be a positive value.");

        }

        public abstract void PrintShipmentDetails();
        #endregion

        override public string ToString()
        {
            return $"Tracking Code: {TrackingCode}\n Description: {Description}\n Weight: {Weight} kg\n Delivery Fee: ${DeliveryFee}\n Estimated Cost: ${EstimatedCost}, \n Destination Address: {Destination.GetFullAddress()}";
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
                Weight = newWeight + extraPackingWeight;
        }

        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                    Destination.City,
                    Destination.Street,
                    Destination.BuildingNumber);

            return copy;
        }


        public Shipment CopyShipment()
        {
            return DeepCopy();
        }
        //Assigning one variable to another makes 2 variables be refering to one object while creating an actual copy makes 2 different objects 

        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }
    }
}

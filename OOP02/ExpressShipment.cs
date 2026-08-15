using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class ExpressShipment:Shipment , ITrackable ,IInsurable
    {

        private decimal extraFee;

        #region Constructor
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination , decimal extrafee) :
            base(trackingCode, description, weight, deliveryfee, destination)
        {
            Extrafees = extrafee;

        } 
        #endregion
        #region Property
        public decimal Extrafees
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Value cannot be negative.");
                extraFee = value;

            }
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost() * 0.08m;
        }

        public override decimal EstimatedCost()
        {
            return DeliveryFee + (Weight * 5) + Extrafees;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public override void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Extra Fee: ${Extrafees}");
        }
        #endregion
    }
}

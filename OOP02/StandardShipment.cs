using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class StandardShipment: Shipment , ITrackable , IInsurable
    {
        public StandardShipment(string trackingCode , string description , decimal weight , decimal deliveryfee , DeliveryAddress destination ):
            base(trackingCode,description , weight, deliveryfee , destination)
        {

        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost() * 0.05m;
        }

        public override decimal EstimatedCost()
        {
            return DeliveryFee + (Weight * 5);
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public override void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}

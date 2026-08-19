using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) 
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost()
        {
            return DeliveryFee + (Weight * 5);
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

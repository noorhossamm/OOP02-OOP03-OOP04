using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class DeliveryReport
    {
        public static void PrintShipmentStatus(ITrackable shipment)
        {
            Console.WriteLine($"Tracking status of shipment is :{shipment.GetTrackingStatus()}");

        }
        public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance cost of shipment is :{shipment.CalculateInsurance()}");

        }
    }
}

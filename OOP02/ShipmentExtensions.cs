using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} --" +
                   $"{shipment.GetType().Name} -- " +
                   $"{shipment.Weight} KG ";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetType().Name == "InternationalShipment";
        }
    }
}

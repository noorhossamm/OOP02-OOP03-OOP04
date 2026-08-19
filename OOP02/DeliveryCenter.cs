using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments = default !;
        private string centerName;

        public string CenterName
        {
            get
            {
                return centerName;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Invalid name ");
                centerName = value;
            }
        }



        public DeliveryCenter(string centername)
        {
            CenterName = centername;
            shipments = new Shipment[20];
        }

        #region Indexer
        public Shipment this[int position]
        {
            get
            {
                if (shipments != null || position >= 0 || position < shipments.Length)
                {
                    return shipments[position];
                }
                else
                {
                    return default;
                }

            }
            set
            {
                if (shipments == null && position < 0 && position > shipments.Length)
                {
                    Console.WriteLine("Cannot set shipment at the specified position.");
                }
                else
                {
                    shipments[position] = value;
                }

            }
        }



        public Shipment this[string name]
        {
            get
            {
                foreach (Shipment shipment in this.shipments)
                {
                    if (shipment.TrackingCode == name)
                    {
                        return shipment;
                    }
                }
                return default;
            }


        }
        #endregion

        #region Methods 
        public bool AddShipment(Shipment s)
        {

 
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] == null)
                    {
                        shipments[i] = s;
                        return true;
                    }
                }

            return false;
        }

        public bool RemoveShipment( string trackCode)
        {
            if (shipments != null) {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null)
                    {
                        if (shipments[i].TrackingCode == trackCode)
                        {
                            shipments[i] = default;
                            return true;
                        }
                }

                }
            }
            return false;

        }

        public void PrintAllShipments()
        {
            if (shipments != null)
            {
                for(int i=0; i< shipments.Length; i++)
                {
                    if (shipments[i] != null)
                    {
                        Console.WriteLine(shipments[i]);
                        Console.WriteLine("----------------------------------------");
                    }
       
                }

            }
        }

        public void PrintTrackingStatuses()
        {
            foreach(ITrackable shipment in shipments)
            {
                if (shipment != null)
                {
                    Console.WriteLine($"{shipment.GetTrackingStatus()}");

                }

            }
 
        }

        public void PrintInsurability() 
        { 
            foreach( IInsurable shipment in shipments)
            {
                if(shipment != null)
                {
                    Console.WriteLine($"Insurabilty for shipment is: {shipment.CalculateInsurance()}");
                }
            }
        }


    }
        #endregion
    }


using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 01
            //a)A class is a reference type, while a struct is a value type.
            //Classes support inheritance, while structs do not support class inheritance.
            //Classes are usually used for more complex objects, while structs are suitable for small data structures.
            //b)Because classes support inheritance, polymorphism, and reference-type behavior, which makes code easier to organize, reuse, and maintain.
            //Question 02
            //a)  Shipment
            //b) ExpressShipment
            //c) TrackingCode()
            //d)To reuse common code from the parent class instead of writing the same code again
            //Improving maintainability and reducing duplication





            //Console.WriteLine("Enter Center name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("----------------------------------------");


            //DeliveryCenter c = new DeliveryCenter(name);
            //Shipment[] s =
            //{
            //        new StandardShipment("SH-101", "Laptop", 3,80, new DeliveryAddress("Cairo", "Tahrir", 15)),
            //        new ExpressShipment("SH-102", "Phone", 2, 60, new DeliveryAddress("ALex", "Agamy", 20), 30),
            //        new InternationalShipment("SH-103", "Television", 8, 125, new DeliveryAddress("Sharqia", "Zag", 30), "Germany ",100)
            //};


            //for (int i = 0; i < s.Length; i++)
            //{

            //    c.AddShipment(s[i]);

            //}
            //c.PrintAllShipments();

            //    string trackingCode;
            //    do
            //    {
            //        Console.Write("Enter Tracking Code: ");
            //         trackingCode = Console.ReadLine();
            //    } while (string.IsNullOrEmpty(trackingCode));

            //    Console.WriteLine("--------------------------------------------");

            //    Shipment searchedShipment = c[trackingCode];
            //    Console.WriteLine(searchedShipment);

            //    c.RemoveShipment("SH-102");
            //    Console.WriteLine("After removal :");
            //    c.PrintAllShipments();




            // Q1
            // a) Method Overloading means having multiple methods with the same name but different parameters[ in count , type , order].
            //    Method Overriding allows a derived class to provide a specific implementation of a method that is already defined in its base class

            // b) Static Binding happens at compile time ,CLR resolve based on refernce type.
            //    Dynamic Binding happens at runtime , CLR resolve based on object type.

            // Q2
            // a) sealed class prevents other classes from inheriting from it.
            // b) sealed class prevents inheritance but a sealed method prevents further overriding of that method.
            // c) No, a sealed method cannot be overridden because sealed keyword stops further overriding.


            //Driver driver = new Driver( 1, "Ahmed Ahmed","010123");


            //Console.WriteLine("Enter Center name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("----------------------------------------");


            //DeliveryCenter center = new DeliveryCenter(name);

            //DeliveryAddress address1 = new DeliveryAddress("Street 1", "Cairo", 10);
            //StandardShipment s1 = new StandardShipment( "SH001", "Laptop", 3, 80,address1);


            //DeliveryAddress address2 =new DeliveryAddress("Street 2", "Giza", 20);
            //ExpressShipment s2 = new ExpressShipment("SH002", "Mobile Phone",2,60,address2,30);

            //DeliveryAddress address3 = new DeliveryAddress("Street 3", "Alexandria", 30);
            //InternationalShipment s3 =new InternationalShipment("SH003","Television",8,120, address3,"Germany",100);

            //center.AddShipment(s1);
            //center.AddShipment(s2);
            //center.AddShipment(s3);

            //center.PrintAllShipments();
            //Console.WriteLine("------------------------------------------");


            //DeliveryHelper d = new DeliveryHelper();
            //Console.WriteLine("Shipment 1 : ");
            //d.PrintShipment(s1);
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Shipment 2 : ");
            //d.PrintShipment(s2);
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Shipment 3 : ");
            //d.PrintShipment(s3);
            //Console.WriteLine("------------------------------------------");


            //s1.UpdateWeight(5);
            //Console.WriteLine($"Updated Weight : {s1.Weight}");
            //Console.WriteLine("------------------------------------------");
            //s1.UpdateWeight(5, 3.5m);
            //Console.WriteLine($"Updated Weight After Packing : {s1.Weight} ");
            //Console.WriteLine("------------------------------------------");



            //Shipment[] shipments =
            //{
            //        new StandardShipment("SH-101", "Laptop", 3,80, new DeliveryAddress("Cairo", "Tahrir", 15)),
            //        new ExpressShipment("SH-102", "Phone", 2, 60, new DeliveryAddress("ALex", "Agamy", 20), 30),
            //        new InternationalShipment("SH-103", "Television", 8, 125, new DeliveryAddress("Sharqia", "Zag", 30), "Germany ",100)
            //};
            //foreach(Shipment s in shipments)
            //{
            //    s.PrintShipmentDetails();
            //    Console.WriteLine("------------------------------------------");
            //}


            // CompletedShipment is sealed, so another class cannot inherit from it .
            // GenerateCustomsReport() is sealed , so it cannot be overridden by another derived class.

            #region OOP04
            #region Part01
            //Q1)
            // a) Abstraction is the process of hiding the implementation details and showing only the essential features of an object to the user.
            //b) Because it reduces complexilty , enhances security , provides maintainabilty , flexibility and reusibility.

            //Q2)
            //a) Abstract class is a class where it contains some concrete methods and other abstract method .
            //So that other classes will inherit from it where they inherit the complete methods and implement the abstract ones.
            //It contains fields , constructors , and it can use any access modifier.

            //Interface  defines a contract where classes that implement the interface must provide the implementation.
            //It does not contain any fields or constructors ,it can contain only method, property ,event, indexer and constant definitions.

            //b)when you want to define a contract that different classes can implement.
            //It is useful when you want a class to have multiple behaviors because a class can implement multiple interfaces.

            //c)No, a class cannot inherit from multiple abstract classes because C# supports single class inheritance.
            ////Yes, a class can implement multiple interfaces.

            #endregion


            #region Part02
            //DeliveryCenter center = new DeliveryCenter("Delivery Center");

            //DeliveryAddress address1 = new DeliveryAddress("Street 1", "Cairo", 10);
            //StandardShipment s1 = new StandardShipment("SH001", "Laptop", 3, 80, address1);


            //DeliveryAddress address2 = new DeliveryAddress("Street 2", "Giza", 20);
            //ExpressShipment s2 = new ExpressShipment("SH002", "Mobile Phone", 2, 60, address2, 30);

            //DeliveryAddress address3 = new DeliveryAddress("Street 3", "Alexandria", 30);
            //InternationalShipment s3 = new InternationalShipment("SH003", "Television", 8, 120, address3, "Germany", 100);

            //center.AddShipment(s1);
            //center.AddShipment(s2);
            //center.AddShipment(s3);

            //center.PrintAllShipments();
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine("Tracking status :");
            //center.PrintTrackingStatuses();

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Insurance:");
            //center.PrintInsurability();

            //Console.WriteLine("----------------------------------");
            //ITrackable[] trackable =
            //{
            //    s1,s2,s3
            //};
            //foreach(ITrackable t in trackable)
            //{
            //    Console.WriteLine(t.GetTrackingStatus());

            //}





            //Console.WriteLine("----------------------------------");
            //IInsurable[] insurability =
            //{
            //    s1,s2,s3
            //};

            //foreach (IInsurable i in insurability)
            //{
            //    Console.WriteLine($"Insurance Cost: {i.CalculateInsurance()} EGP");
            //}


            #endregion
            #endregion

            #region OOP05
            #region Part01
            //Q1)
            //a.Both will refer to the same object as the second variable receives a reference to the same object in memory.
            //b.No it is just one object but 2 variables refer to it.
            //c.Copying the reference means both variables point to the same object so changes through one variable affects the other.
            //Copying the object means creating a separate object  with copied data so changes to one object do not necessarily affect the other.


            //Q2)
            //a.A shallow copy creates a new object and copies all value type fields but for reference type fields only the references are copied (both objects point to the same nested objects).
            //b.A Deep Copy creates a new object and also creates independent copies of its reference type members.
            //c.The reference is copied so both the original and copied objects refer to the same referenced object
            //d.New copies of the referenced objects are created so the original and copied objects have independent reference type members.
            //e.when you need to modify the copied object's reference data without affecting the original object.

            //Q3)
            //a.A static field belongs to the class itself, so there is only one shared copy for all objects of that class.
            //An instance field belongs to each object, so every object has its own separate copy.

            //b. A static method a method that belongs to the class itself rather than a specific object. No.


            //c.It is a constuctor used to initialize static members of a class. It has no parameters and no access modifier.
            //It is executed automatically once before the class is first used

            //d.A static class contains only static members and cannot be instantiated. no.

            //Q4)
            //a.Extension methods let you add new methods to existing types without modifying the original type or creating a new derived type.
            //b.this
            //c.Inside a static class.
            //d.No.It can only access members that are accessible from where the extension method is declared

            #endregion

            #region Part02
            #region Question02
            //Shipment s1 = new StandardShipment("SH-101", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 15));
            //Shipment original = s1;

            //Shipment shallowCopy = original.ShallowCopy();

            //Console.WriteLine($"Before change:");
            //Console.WriteLine($"Original : {original.Destination.City}");
            //Console.WriteLine($"Copied   : {shallowCopy.Destination.City}");

            //shallowCopy.Destination.City = "Giza";

            //Console.WriteLine();
            //Console.WriteLine($"After change:");
            //Console.WriteLine($"Original : {original.Destination.City}");
            //Console.WriteLine($"Copied   : {shallowCopy.Destination.City}");
            #endregion

            #region Question03
            //Shipment s1 = new StandardShipment("SH-101", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 15));
            //Shipment original = s1;

            //Shipment deepCopy = original.DeepCopy();

            //Console.WriteLine($"Before change:");
            //Console.WriteLine($"Original : {original.Destination.City}");
            //Console.WriteLine($"Copied   : {deepCopy.Destination.City}");

            //deepCopy.Destination.City = "Giza";

            //Console.WriteLine();
            //Console.WriteLine($"After changing :");
            //Console.WriteLine($"Original : {original.Destination.City}");
            //Console.WriteLine($"Copied   : {deepCopy.Destination.City}");
            #endregion


            //Shipment s1 = new StandardShipment("SH-101", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 15));


            //Shipment s2 = s1;

            //Console.WriteLine($"Same Object? {object.ReferenceEquals(s1, s2)}");
            //Console.WriteLine($"shipment1 HashCode : {s1.GetHashCode()}");
            //Console.WriteLine($"shipment2 HashCode : {s2.GetHashCode()}"); 

            //creating shallow and deep copy is in Question02 and Question03

            //Static counter


            Shipment s1 = new ExpressShipment("SH-102","Mobile",60,100,new DeliveryAddress("Giza", "Main Street", 20),20);

            Shipment s2 = new InternationalShipment("SH-103", "TV",8,120,new DeliveryAddress("Alexandria", "Street 3", 30),"Germany",100);

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");


            // The static constructor is called automatically by the CLR before the first use of Shipment ,it prints that the system is initialiazed

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            DeliveryUtilities.PrintSystemTitle();

            //Shipment Extensions
            Console.WriteLine(s1.GetSummary());
            Console.WriteLine("---------------------------");
            Console.WriteLine(s2.GetSummary());

            Console.WriteLine("---------------------------");

            Console.WriteLine($"s1 Is Delivered? {s1.IsDelivered()}");
            Console.WriteLine($"s2 Is Delivered? {s2.IsDelivered()}");

            #endregion
            #endregion




        }
    }
}
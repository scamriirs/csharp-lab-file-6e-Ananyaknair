//parking system
using System;

class ParkingSystem
{
    static void Main()
    {
        int vipFacultyCount = 0, studentCarCount = 0, digitalCarCount = 0;
        int totalRevenue = 0;
        int totalVehicles = 0;
        int choice;

        Console.Write("Enter the number of vehicles to register: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nSelect vehicle type:");
            Console.WriteLine("1. VIP/Faculty Car (No charge)");
            Console.WriteLine("2. Student Car (₹10 fee)");
            Console.WriteLine("3. Digital Car (₹20 fee)");
            Console.WriteLine("4. Generate Report");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                vipFacultyCount++;
                totalVehicles++;
                Console.WriteLine("VIP/Faculty Car registered. No fee charged.");
            }
            else if (choice == 2)
            {
                studentCarCount++;
                totalRevenue += 10;
                totalVehicles++;
                Console.WriteLine("Student Car registered. ₹10 fee collected.");
            }
            else if (choice == 3)
            {
                digitalCarCount++;
                totalRevenue += 20;
                totalVehicles++;
                Console.WriteLine("Digital Car registered. ₹20 fee collected.");
            }
            else if (choice == 4)
            {
                Console.WriteLine("\n------ Parking Summary Report ------");
                Console.WriteLine("Total VIP/Faculty Cars: " + vipFacultyCount);
                Console.WriteLine("Total Student Cars: " + studentCarCount);
                Console.WriteLine("Total Digital Cars: " + digitalCarCount);
                Console.WriteLine("Total Vehicles Parked: " + totalVehicles);
                Console.WriteLine("Total Revenue Collected: ₹" + totalRevenue);
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please enter a valid option.");
            }
        }
    }
}

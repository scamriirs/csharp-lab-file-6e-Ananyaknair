//write a program for the seat booking management system using 2d array menu driven
1) view the seats
2) book the seat(provide rows and column no)
3)cancel the seat(provide rows and column no)
4) check the availability of particular seat 


using System;

class SeatBookingSystem
{
    static char[,] seats = new char[5, 5];  // A 5x5 array to represent seats (A for Available, B for Booked)
    
    static void Main()
    {
        // Initialize all seats to 'A' (Available)
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                seats[i, j] = 'A';
            }
        }
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Seat Booking System Menu:");
            Console.WriteLine("1. View seats");
            Console.WriteLine("2. Book a seat");
            Console.WriteLine("3. Cancel a seat");
            Console.WriteLine("4. Check availability of a seat");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");
            
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    ViewSeats();
                    break;
                case 2:
                    BookSeat();
                    break;
                case 3:
                    CancelSeat();
                    break;
                case 4:
                    CheckAvailability();
                    break;
                case 5:
                    Console.WriteLine("Exiting system. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
    
  
    static void ViewSeats()
    {
        Console.WriteLine("\nSeat Layout:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(seats[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
    
    
    static void BookSeat()
    {
        Console.Write("\nEnter row number (0-4): ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter column number (0-4): ");
        int col = int.Parse(Console.ReadLine());

        if (row >= 0 && row < 5 && col >= 0 && col < 5)
        {
            if (seats[row, col] == 'B')
            {
                Console.WriteLine("Seat is already booked.");
            }
            else
            {
                seats[row, col] = 'B';
                Console.WriteLine("Seat booked successfully!");
            }
        }
        else
        {
            Console.WriteLine("Invalid row or column number.");
        }
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
    

    static void CancelSeat()
    {
        Console.Write("\nEnter row number (0-4): ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter column number (0-4): ");
        int col = int.Parse(Console.ReadLine());

        if (row >= 0 && row < 5 && col >= 0 && col < 5)
        {
            if (seats[row, col] == 'A')
            {
                Console.WriteLine("Seat is already available.");
            }
            else
            {
                seats[row, col] = 'A';
                Console.WriteLine("Seat canceled successfully!");
            }
        }
        else
        {
            Console.WriteLine("Invalid row or column number.");
        }
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
    
  
    static void CheckAvailability()
    {
        Console.Write("\nEnter row number (0-4): ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter column number (0-4): ");
        int col = int.Parse(Console.ReadLine());

        if (row >= 0 && row < 5 && col >= 0 && col < 5)
        {
            if (seats[row, col] == 'A')
            {
                Console.WriteLine("Seat is available.");
            }
            else
            {
                Console.WriteLine("Seat is booked.");
            }
        }
        else
        {
            Console.WriteLine("Invalid row or column number.");
        }
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}




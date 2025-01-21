using Project___Fitness;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Membership System!");

        bool exit = false;
        while (!exit)
        {
            Member member = null; 
            Card card = null; 
            int currentStep = 1; 
            bool processComplete = false; 
            while (!processComplete)
            {
                Console.WriteLine("\nMenu:");
                if (currentStep == 1) Console.WriteLine("1. Create a Member");
                if (currentStep == 2) Console.WriteLine("2. Select Membership Type and Length");
                if (currentStep == 3) Console.WriteLine("3. Display Membership Price");
                if (currentStep == 4) Console.WriteLine("4. Set Expiry Date");
                if (currentStep == 5) Console.WriteLine("5. Validate Card");
                Console.WriteLine("6. Exit");

                // After step 5 is completed, show restart and check validation options
                if (processComplete)
                {
                    Console.WriteLine("7. Restart");
                    Console.WriteLine("8. Check Card Validation for Existing User");
                }

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (currentStep != 1)
                        {
                            Console.WriteLine("You cannot access this option right now. Follow the correct order.");
                        }
                        else
                        {
                            member = CreateMember();
                            card = new Card(); // Create a new card for the member
                            Console.WriteLine("Member and card created successfully!");
                            Console.WriteLine("Next: Select Membership Type and Length (Option 2).");
                            currentStep = 2; // Move to the next step
                        }
                        break;
                    case "2":
                        if (currentStep != 2)
                        {
                            Console.WriteLine("You cannot access this option right now. Follow the correct order.");
                        }
                        else
                        {
                            SelectMembership(card);
                            Console.WriteLine("Next: Display Membership Price (Option 3).");
                            currentStep = 3; // Move to the next step
                        }
                        break;
                    case "3":
                        if (currentStep != 3)
                        {
                            Console.WriteLine("You cannot access this option right now. Follow the correct order.");
                        }
                        else
                        {
                            card.Price();
                            Console.WriteLine("Next: Set Expiry Date (Option 4).");
                            currentStep = 4; // Move to the next step
                        }
                        break;
                    case "4":
                        if (currentStep != 4)
                        {
                            Console.WriteLine("You cannot access this option right now. Follow the correct order.");
                        }
                        else
                        {
                            card.SetExpiryDate();
                            Console.WriteLine($"Card expiry date set to: {card.dateTo}");
                            Console.WriteLine("Next: Validate Card (Option 5).");
                            currentStep = 5; // Move to the next step
                        }
                        break;
                    case "5":
                        if (currentStep != 5)
                        {
                            Console.WriteLine("You cannot access this option right now. Follow the correct order.");
                        }
                        else
                        {
                            card.Validation();
                            Console.WriteLine("Process completed. You can restart or exit.");
                            processComplete = true; // Mark process as complete
                            currentStep = 7 & 8;
                        }
                        break;
                    case "6":
                        exit = true;
                        processComplete = true;
                        Console.WriteLine("Exiting the system. Goodbye!");
                        break;
                    case "7":
                        if (!processComplete)
                        {
                            Console.WriteLine("You cannot restart until the process is complete.");
                        }
                        else
                        {
                            Console.WriteLine("Restarting the process...");
                            processComplete = false; // Reset the process completion
                            currentStep = 1; // Reset the step to the start
                        }
                        break;
                    case "8":
                        if (!processComplete)
                        {
                            Console.WriteLine("You cannot check validation until the process is complete.");
                        }
                        else
                        {
                            // Check validation for the existing user (card validation)
                            Console.WriteLine($"Checking card validation for {member.Name}...");
                            card.Validation();
                            Console.WriteLine("You can now exit or restart.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    static Member CreateMember()
    {
        Console.Write("Enter Member ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Member Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Member Age: ");
        int age = int.Parse(Console.ReadLine());

        return new Member(id, name, age, null, null);
    }

    static void SelectMembership(Card card)
    {
        Console.WriteLine("Select Membership Type:");
        Console.WriteLine("1. Standard");
        Console.WriteLine("2. Premium");
        Console.WriteLine("3. VIP");
        Console.Write("Enter your choice: ");
        string typeChoice = Console.ReadLine();

        card.Type = typeChoice switch
        {
            "1" => MembershipType.Standard,
            "2" => MembershipType.Premium,
            "3" => MembershipType.VIP,
            _ => throw new ArgumentException("Invalid membership type.")
        };

        Console.WriteLine("Select Membership Length:");
        Console.WriteLine("1. One Month");
        Console.WriteLine("2. Three Months");
        Console.WriteLine("3. Six Months");
        Console.WriteLine("4. One Year");
        Console.Write("Enter your choice: ");
        string lengthChoice = Console.ReadLine();

        card.Length = lengthChoice switch
        {
            "1" => MembershipLength.one_month,
            "2" => MembershipLength.three_months,
            "3" => MembershipLength.six_months,
            "4" => MembershipLength.one_year,
            _ => throw new ArgumentException("Invalid membership length.")
        };

        Console.WriteLine($"Membership selected: Type={card.Type}, Length={card.Length}");
    }
}

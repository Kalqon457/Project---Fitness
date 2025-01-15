namespace Project___Fitness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public void Price()
{
    int Price = 0;
    if (Type == MembershipType.Standard)
    {
        switch (Length)
        {
            case MembershipLength.one_month:
                Price = 65;
                break;
            case MembershipLength.three_months:
                Price = 175;
                break;
            case MembershipLength.six_months:
                Price = 320;
                break;
            case MembershipLength.one_year:
                Price = 600;
                break;
            default:
                throw new ArgumentException("Invalid membership type.");


        }
    }
    else if (Type == MembershipType.Premium)
    {
        switch (Length)
        {
            case MembershipLength.one_month:
                Price = 85;
                break;
            case MembershipLength.three_months:
                Price = 235;
                break;
            case MembershipLength.six_months:
                Price = 440;
                break;
            case MembershipLength.one_year:
                Price = 840;
                break;
            default:
                throw new ArgumentException("Invalid membership type.");
        }
    }
    else if (Type == MembershipType.VIP)
    {
        switch (Length)
        {
            case MembershipLength.one_month:
                Price = 100;
                break;
            case MembershipLength.three_months:
                Price = 280;
                break;
            case MembershipLength.six_months:
                Price = 530;
                break;
            case MembershipLength.one_year:
                Price = 1000;
                break;
            default:
                throw new ArgumentException("Invalid membership type.");
                
        }

    }
    Console.WriteLine(Price);
}
public void SetExpiryDate ()
{
    dateFrom = DateTime.Now;
    switch (Length)
    {
        case MembershipLength.one_month:
            this.dateTo = dateFrom.AddMonths(1);
            break;
        case MembershipLength.three_months:
            this.dateTo = dateFrom.AddMonths(3);
            break;
        case MembershipLength.six_months:
            this.dateTo = dateFrom.AddMonths(6);
            break;
        case MembershipLength.one_year:
            this.dateTo = dateFrom.AddYears(1);
            break;
        default:
            throw new ArgumentException("Invalid membership length.");
    }
}

public void Validation()
{
    if (DateTime.Now <= dateTo)
    {
        Console.WriteLine("The Card is valid");
    }
    else
    {
        Console.WriteLine("The Card is invalid");
    }
}
        }
    }
}

 Member ivan = new Member ();
 Card Card1 = new Card(MembershipLength.one_year,MembershipType.Standard);
 ivan.Card = Card1;
 Card1.Price();
 Card1.dateTo = new DateTime(2025, 1, 12);
 ivan.Card.Validation();
 Console.WriteLine(Card1.dateTo);

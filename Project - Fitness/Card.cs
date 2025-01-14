using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project___Fitness
{
    public class Card
    {
        public MembershipType Type { get; set; }
        public MembershipLength Length { get; set; }

        public DateTime dateFrom { get; set; }
        public DateTime dateTo { get; set; }

        public Card(MembershipLength Length, MembershipType Type)
        {
            this.Length = Length;
            this.Type = Type;
        }

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
        }
        public void SetExpiryDate ()
        {
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
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatForm
{
    public class Card
    {
        public string Bank { get; set; }
        public string Number { get; set; }
        public string Pin { get; set; }
        public double Balans { get; set; }
        public DateOnly Date { get; set; }

        public Card() { }
        public Card(string bank, string number, string pin, double balans, DateOnly data)
        {
            Bank = bank;
            Number = number;
            Pin = pin;
            Balans = balans;
            Date = data;

        }

        public void CardShow() => Console.WriteLine($" Данні карти: \n банк-імітент :\t\t{Bank},\n номер карти : \t\t{Number},\n строк дії: \t\t{Date.Month}/{Date.Year}");
    }
}

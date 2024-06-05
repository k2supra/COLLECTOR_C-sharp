using System;
using System.Collections.Generic;

namespace ex_3
{
    public delegate void CCActionsDelegate(decimal value);
    public delegate void CCPINDelegate(int value);

    class CreditCard
    {
        public string FullName { get; private set; }
        public string CardNumber { get; private set; }
        public string ExpiryDate { get; private set; }
        public int PIN { get; private set; }
        public decimal CreditLimit { get; private set; }
        public decimal Balance { get; private set; }

        public CreditCard(string fullName, string cardNumber, string expiryDate, int pin, decimal creditLimit, decimal balance)
        {
            this.FullName = fullName;
            this.CardNumber = cardNumber;
            this.ExpiryDate = expiryDate;
            this.PIN = pin;
            this.CreditLimit = creditLimit;
            this.Balance = balance;
        }

        public void Replenishment(decimal amount)
        {
            this.Balance += amount;
        }

        public void Spend(decimal amount)
        {
            if (this.Balance - amount < 0)
            {
                Console.WriteLine("Error. You can break the limit if you make a purchase");
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public void CreditMoney(decimal amount)
        {
            this.CreditLimit += amount;
        }

        public void ChangePIN(int newPin)
        {
            this.PIN = newPin;
        }

        public void Display()
        {
            Console.WriteLine($"Owner: {FullName}");
            Console.WriteLine($"Card number: {CardNumber}");
            Console.WriteLine($"Expiry date: {ExpiryDate}");
            Console.WriteLine($"PIN code: {PIN}");
            Console.WriteLine($"Credit limit: {CreditLimit}");
            Console.WriteLine($"Balance: {Balance}\n\n");
        }
    }

    class User
    {
        public event CCActionsDelegate ReplenishmentEvent;
        public event CCActionsDelegate SpendEvent;
        public event CCActionsDelegate CreditLimitReachedEvent;
        public event CCActionsDelegate CreditUsedEvent;
        public event CCPINDelegate PinChangedEvent;

        private List<CreditCard> creditCards = new List<CreditCard>();

        public User(List<CreditCard> creditCards)
        {
            this.creditCards = creditCards;
        }

        public User(CreditCard creditCard)
        {
            this.creditCards.Add(creditCard);
        }

        public User(CreditCard[] creditCardArray)
        {
            foreach (CreditCard creditCard in creditCardArray) { this.creditCards.Add(creditCard); }
        }

        public void AddCard(CreditCard creditCard) { creditCards.Add(creditCard); }
        public void RemoveCard(int index) { creditCards.RemoveAt(index - 1); }
        public void Display()
        {
            foreach (var item in creditCards)
            {
                item.Display();
            }
        }

        public void Replenishment(decimal amount, int indexOfCard)
        {
            if (ReplenishmentEvent != null)
            {
                ReplenishmentEvent(amount);
            }
            this.creditCards[indexOfCard - 1].Replenishment(amount);
        }

        public void Spend(decimal amount, int indexOfCard)
        {
            if (SpendEvent != null)
            {
                SpendEvent(amount);
            }
            this.creditCards[indexOfCard - 1].Spend(amount);

            if (this.creditCards[indexOfCard - 1].Balance < 0)
            {
                if (CreditUsedEvent != null)
                {
                    CreditUsedEvent(amount);
                }
            }

            if (this.creditCards[indexOfCard - 1].Balance <= this.creditCards[indexOfCard - 1].CreditLimit)
            {
                if (CreditLimitReachedEvent != null)
                {
                    CreditLimitReachedEvent(this.creditCards[indexOfCard - 1].CreditLimit);
                }
            }
        }

        public void ChangePIN(int newPin, int indexOfCard)
        {
            if (PinChangedEvent != null)
            {
                PinChangedEvent(newPin);
            }
            this.creditCards[indexOfCard - 1].ChangePIN(newPin);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard[] creditCards =
            {
                new CreditCard("Bob Marley", "4652 1452 3002 0145", "25.10.2025", 236, 20000, 3000),
                new CreditCard("Bob Marley", "1234 5678 9012 3456", "25.10.2025", 236, 20000, 3000),
                new CreditCard("Bob Marley", "1098 7654 3210 9874", "25.10.2025", 236, 20000, 3000)
            };

            User user = new User(creditCards);

            user.ReplenishmentEvent += ReplenishmentHandler;
            user.SpendEvent += SpendHandler;
            user.CreditLimitReachedEvent += CreditLimitReachedHandler;
            user.CreditUsedEvent += CreditUsedHandler;
            user.PinChangedEvent += PinChangedHandler;

            user.Replenishment(500, 1);
            user.Spend(3500, 2);
            user.ChangePIN(1234, 3);

            user.Display();
        }

        static void ReplenishmentHandler(decimal amount)
        {
            Console.WriteLine($"Replenished with amount: {amount}");
        }

        static void SpendHandler(decimal amount)
        {
            Console.WriteLine($"Spent amount: {amount}");
        }

        static void CreditLimitReachedHandler(decimal limit)
        {
            Console.WriteLine($"Credit limit reached: {limit}");
        }

        static void CreditUsedHandler(decimal amount)
        {
            Console.WriteLine($"Credit used: {amount}");
        }

        static void PinChangedHandler(int newPin)
        {
            Console.WriteLine($"PIN changed to: {newPin}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankManagement
{
    public class ManageUser
    {
        public enum Options
        {
            NewUser = 1,
            Credit = 2,
            Debit = 3,
            DisplayAllDetails = 4,
            DisplayAllTransaction = 5,
            DisplayPersonDetails = 6,
            ShowMinMaxAmount = 7,
            Exit = 8
        }

        public void ManagePersons(ManagePersonList personList)
        {
            while (true)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Choose Options : \n1.New User\n2.Credit\n3.Debit\n4.Display All Details" +
                    "\n5.Display All Transactions\n6.Display Person Details " +
                    "\n7.Show Minmum Maximum Amount\n8.Exit\n");



                int option;
                try
                {
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        string accountNumber;
                        Regex reg = new Regex(@"^[0-9]{6}$");

                        switch (option)
                        {
                            case (int)Options.NewUser:
                                ManagePersonList managePerson = new ManagePersonList();
                                managePerson.AddPerson(personList);
                                break;
                            case (int)Options.Credit:
                                Console.WriteLine("Enter Account Number : ");
                                accountNumber = Console.ReadLine();
                                if (reg.IsMatch(accountNumber))
                                {
                                    Person person = personList.Persons.Find(p => p.AccountNumber == accountNumber);
                                    if (person != null)
                                    {
                                        person.Deposit();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Person dosen't exist with {accountNumber} account number...");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid Account number...");
                                }
                                break;

                            case (int)Options.Debit:
                                Console.WriteLine("Enter Account Number : ");
                                accountNumber = Console.ReadLine();
                                if (reg.IsMatch(accountNumber))
                                {
                                    Person personDebit = personList.Persons.Find(p => p.AccountNumber == accountNumber);
                                    if (personDebit != null)
                                    {
                                        personDebit.Withdraw();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Person dosen't exist with {accountNumber} account number...");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid Account number...");
                                }             
                                break;

                            case (int)Options.DisplayAllDetails:
                                BankAccount account = new BankAccount();
                                account.DisplayInformation(personList);
                                break;
                            case (int)Options.DisplayAllTransaction:
                                Console.WriteLine("Enter Account Number : ");
                                accountNumber = Console.ReadLine();
                                if (reg.IsMatch(accountNumber))
                                {
                                    BankAccount bankAccount = new BankAccount();
                                    bankAccount.DisplayInformation(accountNumber, personList);
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid Account number...");
                                }                           
                                break;
                            case (int)Options.DisplayPersonDetails:
                                Console.WriteLine("Enter Account Number : ");
                                accountNumber = Console.ReadLine();
                                if (reg.IsMatch(accountNumber))
                                {
                                    Person displayPerson = personList.Persons.Find(p => p.AccountNumber == accountNumber);
                                    BankAccount personAccount = new BankAccount();
                                    personAccount.DisplayInformation(displayPerson);
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid Account number...");
                                }                     
                                break;
                            case (int)Options.ShowMinMaxAmount:
                                Console.WriteLine("Enter Account Number : ");
                                accountNumber = Console.ReadLine();
                                if (reg.IsMatch(accountNumber))
                                {
                                    List<Transaction> transactionList = personList.Persons.Find(p => p.AccountNumber == accountNumber).Transactions;
                                    BankAccount showAccountInfo = new BankAccount();
                                    showAccountInfo.ShowMinMaxAmount(transactionList);
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid Account number...");
                                }
                                break;
                            case (int)Options.Exit:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Enter valid option...");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid option...");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

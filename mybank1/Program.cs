using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybank1
{

    class Program
    {

        int num = 2;
        int custid;
        List<accountholder> custlist;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.title();
            p.signup();



            // Create a list of customers.
            List<accountholder> custlist = new List<accountholder>();

            // Add customers to the list.
            custlist.Add(new accountholder()
            {
                id = 0,
                name = "John Cena",
                email = "JC@gmail.co.nz",
                dob = "21/3/55",
                address = "Drake Lane, te aro",
                personalbalance = 100123,
                loanbalance = 503456,
                saving = 2034
            });
            custlist.Add(new accountholder()
            {
                id = 1,
                name = "Kit Kat",
                email = "KK@gmail.co.nz",
                dob = "1/6/01",
                address = "Bunny St, Piptea",
                personalbalance = 98,
                loanbalance = 63456,
                saving = 20084
            });

        }

        private void title()
        {
            Console.WriteLine("----- $ Welcome to My Bank Dashboard $ ------");
        }

        private void signup()
        {
            Console.WriteLine();
            Console.WriteLine("Sign up as a new cuctomer.");
            // Create a list of customers.
            List<accountholder> custlist = new List<accountholder>();

            // Add customers to the list.
            custlist.Add(new accountholder()
            {
                id = 0,
                name = "John Cena",
                email = "JC@gmail.co.nz",
                dob = "21/3/55",
                address = "Drake Lane, te aro",
                personalbalance = 100123,
                loanbalance = 503456,
                saving = 2034
            });
            custlist.Add(new accountholder()
            {
                id = 1,
                name = "Kit Kat",
                email = "KK@gmail.co.nz",
                dob = "1/6/01",
                address = "Bunny St, Piptea",
                personalbalance = 98,
                loanbalance = 63456,
                saving = 20084
            });
            custlist.Add(new accountholder()
            {
                id = 2,
                name = "Rose Mary",
                email = "Rosem@gmail.co.nz",
                dob = "25/12/92",
                address = "Clyde St, Island Bay",
                personalbalance = 11987,
                loanbalance = 8456,
                saving = 203034
            });

            Program p = new Program();
            Console.WriteLine("Enter Details your deatails for sign up");
            Console.WriteLine("Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Email: (contain @ or app will restart) ");
            String email = Console.ReadLine();
            if (!email.Contains("@"))
            {
                Console.WriteLine("Wrong input");
                signup();
            }
            Console.WriteLine("Address: ");
            String address = Console.ReadLine();
            Console.WriteLine("Date of brith: ");//take in any string. 
            String dob = Console.ReadLine();

            //balance
            Console.WriteLine("Opening transfered balanced: (contain numeric VALUE or app will restart)");
            String balancestring = Console.ReadLine();
            double d;
            if (!Double.TryParse(balancestring, out d))
            {
                Console.WriteLine("Wrong input");
                signup();
            }
            double balance = d;

            //loan
            Console.WriteLine("loan acqusion amount: (contain numeric VALUE or app will restart)");
            String loanstring = Console.ReadLine();
            double d1;
            if (!Double.TryParse(loanstring, out d1))
            {
                Console.WriteLine("Wrong input");
                signup();
            }
            double loan = d1;
            Console.WriteLine("Saving balance: (contain numeric VALUE or app will restart)");
            String savingstring = Console.ReadLine();
            double d2;
            if (!Double.TryParse(savingstring, out d2))
            {
                Console.WriteLine("Wrong input");
                signup();
            }
            double savinbal = d2;
            num = num + 1;

            custlist.Add(new accountholder()
            {
                id = num,
                name = name,
                email = email,
                dob = dob,
                address = address,
                personalbalance = balance,
                loanbalance = loan,
                saving = savinbal
            });
            Console.WriteLine("Your customer number is " + num + ". Keep it handy.");
            //Console.WriteLine(custlist.Equals(new accountholder { id = num }));
            //foreach (accountholder cust in custlist)
            //{
            //    if (cust.id.Equals(num))
            //    {
            //        Console.WriteLine(cust);
            //    }
            //}
            meun();
            void meun()
            {
                Console.WriteLine();
                Console.WriteLine("1. Remove a customer");
                Console.WriteLine("2. Edit ALL of your Customer details");
                Console.WriteLine("3. Add New Customer");
                Console.WriteLine("Input number");
                string meunnum = Console.ReadLine();

                if (meunnum == "1")
                {
                    remove();

                }
                else if (meunnum == "2")
                {
                    edit();
                }
                else if (meunnum == "3")
                {
                    newcust();
                }
                else { meun(); }
            }

            void newcust()
            {
                Console.WriteLine("Name: ");
                String name1 = Console.ReadLine();
                Console.WriteLine("Email: ");
                String email1 = Console.ReadLine();
                if (!email.Contains("@"))
                {
                    Console.WriteLine("Wrong input");
                    edit();
                }
                Console.WriteLine("Address: ");
                String address1 = Console.ReadLine();
                Console.WriteLine("Date of brith: ");//take in any string. 
                String dob1 = Console.ReadLine();

                //balance
                Console.WriteLine("Opening transfered balanced: (contain numeric VALUE or app will restart the form)");
                String balancestring1 = Console.ReadLine();
                double dt;
                if (!Double.TryParse(balancestring1, out dt))
                {
                    Console.WriteLine("Wrong input");
                    newcust();
                }
                double balance1 = dt;

                //loan
                Console.WriteLine("loan acqusion amount: (contain numeric VALUE or app will restart the form) ");
                String loanstring1 = Console.ReadLine();
                double dt1;
                if (!Double.TryParse(loanstring1, out dt1))
                {
                    Console.WriteLine("Wrong input");
                    newcust();
                }
                double loan1 = dt1;
                Console.WriteLine("Saving balance (contain numeric VALUE or app will restart the form)");
                String savingstring1 = Console.ReadLine();
                double dt2;
                if (!Double.TryParse(savingstring1, out dt2))
                {
                    Console.WriteLine("Wrong input");
                    newcust();
                }
                double savinbal1 = dt2;
                num = num + 1;

                custlist.Add(new accountholder()
                {
                    id = num,
                    name = name1,
                    email = email1,
                    dob = dob1,
                    address = address1,
                    personalbalance = balance1,
                    loanbalance = loan1,
                    saving = savinbal1
                });
                Console.WriteLine("Your customer number is " + num + ". Keep it handy.");

                foreach (accountholder cust in custlist)
                {
                    Console.WriteLine(cust);
                }
                meun();
            }
                void edit()
            {
                Console.WriteLine("Enter Customer ID which you like to edit:");
                string removeing = Console.ReadLine();
                int d5;
                if (!int.TryParse(removeing, out d5))
                {
                    Console.WriteLine("Wrong input");
                }
                int removes = d5;
                Console.WriteLine("\nContains(\"removeing\"): {0}",
                custlist.Remove(new accountholder { id = removes }));
                Console.WriteLine("Name: ");
                String name1 = Console.ReadLine();
                Console.WriteLine("Email: ");
                String email1 = Console.ReadLine();
                if (!email.Contains("@"))
                {
                    Console.WriteLine("Wrong input");
                    edit();
                }
                Console.WriteLine("Address: ");
                String address1 = Console.ReadLine();
                Console.WriteLine("Date of brith: ");//take in any string. 
                String dob1 = Console.ReadLine();

                //balance
                Console.WriteLine("Opening transfered balanced: (contain numeric VALUE or app will restart the form)");
                String balancestring1 = Console.ReadLine();
                double dt;
                if (!Double.TryParse(balancestring1, out dt))
                {
                    Console.WriteLine("Wrong input");
                    edit();
                }
                double balance1 = dt;

                //loan
                Console.WriteLine("loan acqusion amount: (contain numeric VALUE or app will restart the form) ");
                String loanstring1 = Console.ReadLine();
                double dt1;
                if (!Double.TryParse(loanstring1, out dt1))
                {
                    Console.WriteLine("Wrong input");
                    edit();
                }
                double loan1 = dt1;
                Console.WriteLine("Saving balance (contain numeric VALUE or app will restart the form)");
                String savingstring1 = Console.ReadLine();
                double dt2;
                if (!Double.TryParse(savingstring1, out dt2))
                {
                    Console.WriteLine("Wrong input");
                    edit();
                }
                double savinbal1 = dt2;

                custlist.Add(new accountholder()
                {
                    id = removes,
                    name = name1,
                    email = email1,
                    dob = dob1,
                    address = address1,
                    personalbalance = balance1,
                    loanbalance = loan1,
                    saving = savinbal1
                });
                Console.WriteLine("Your customer number is " + removes + ". Keep it handy.");

                foreach (accountholder cust in custlist)
                {
                    Console.WriteLine(cust);
                }
                meun();
            }

            void remove()
            {
                Console.WriteLine("Enter Customer ID which you like to remove:");
                string removeing = Console.ReadLine();
                int d5;
                if (!int.TryParse(removeing, out d5))
                {
                    Console.WriteLine("Wrong input");
                }
                int removes = d5;
                Console.WriteLine("\nContains(\"removeing\"): {0}",
                custlist.Contains(new accountholder { id = removes }));
                custlist.Remove(new accountholder { id = removes });
                foreach (accountholder cust in custlist)
                {
                    Console.WriteLine(cust);
                }
                meun();
            }
        }

    }
    
    }
    public class accountholder : IEquatable<accountholder>
    {

        public String name { get; set; }

        public int id { get; set; }

        public String email { get; set; }
        public String dob { get; set; }
        public String address { get; set; }
        public double personalbalance { get; set; }
        public double loanbalance { get; set; }
        public double saving { get; set; }

        public override string ToString()
        {
            return "ID: " + id + " Name: " + name + " Email: " + email + " Date of Birth: " + dob + "   Address: " + address + " Bal $" + personalbalance + " Loan $" + loanbalance + " Saving $" + saving;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            accountholder objAsPart = obj as accountholder;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return id;
        }
        public bool Equals(accountholder other)
        {
            if (other == null) return false;
            return (this.id.Equals(other.id));
        }
        // Should also override == and != operators.

    }
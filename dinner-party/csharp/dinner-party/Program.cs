using System;
using System.Collections.Generic;

namespace dinner_party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> Table1 = new List<Guest>();
            List<Guest> Table2 = new List<Guest>();
            List<string> TableOccupations = new List<string>();


            List<Guest> GuestList = new List<Guest>()
                {
                new Guest(
                "Marilyn Monroe",
                    "entertainer",
                    "(1926 - 1962) American actress, singer, model"
                ),
                new Guest(
                    "Abraham Lincoln",
                    "politician",
                    "(1809 - 1865) US President during American civil war"
                ),
                new Guest(
                    "Martin Luther King",
                    "activist",
                    "(1929 - 1968)  American civil rights campaigner"
                ),
                new Guest(
                    "Rosa Parks",
                    "activist",
                    "(1913 - 2005)  American civil rights activist"
                ),
                new Guest(
                    "Peter Sellers",
                    "entertainer",
                    "(1925 - 1980) British actor and comedian"
                ),
                new Guest(
                    "Alan Turing",
                    "computer scientist",
                    "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                ),
                new Guest(
                    "Admiral Grace Hopper",
                    "computer scientist",
                    "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                ),
                new Guest(
                    "Indira Gandhi",
                    "politician",
                    "(1917 - 1984) Prime Minister of India 1966 - 1977"
                )
                };

            foreach (Guest person in GuestList)
            {

                if (TableOccupations.Contains(person.Occupation))
                {
                    Table2.Add(person);

                }
                else
                {
                    Table1.Add(person);
                    TableOccupations.Add(person.Occupation);
                }
            }

            List<tables> TableList = new List<tables>();
            tables TypeTable = new tables("Table1", Table1);
            TableList.Add(TypeTable);
            TypeTable = new tables("Table2", Table2);
            TableList.Add(TypeTable);

            foreach (tables guest in TableList)
            {
                Console.WriteLine($"{guest.Tablename}");
                foreach (Guest person in guest.Tables)
                {
                    Console.WriteLine($"{person.Name} {person.Occupation} {person.Bio} ");
                }

            }
        }



        public class tables
        {
            public string Tablename { get; set; }
            public List<Guest> Tables { get; set; }

            public tables(string tablename, List<Guest> tables)
            {
                Tablename = tablename;
                Tables = tables;


            }

        }


    }
}

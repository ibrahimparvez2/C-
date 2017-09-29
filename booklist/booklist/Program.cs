using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booklist
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            List<Book> booklist = new List<Book>(); 

            //Dummy Data......
            Book book1 = new Book();
            book1.title = "BFG";
            book1.author = "jc";
            book1.ISBN = "111";
            book1.price = 4;

            Book book3 = new Book();
            book3.title = "bexample";
            book3.author = "jc";
            book3.ISBN = "222";
            book3.price = 4;


            Book book4 = new Book();
            book4.title = "aexample";
            book4.author = "jc";
            book4.ISBN = "333";
            book4.price = 4;

            //test book example to screen
            booklist.Add(book1);
            booklist.Add(book3);
            booklist.Add(book4);
            //Book.displayList(booklist);

            Console.WriteLine("Menu Options for Booklist");
            Console.WriteLine("select <a> to add a book");
            Console.WriteLine("select <d> display book");
            Console.WriteLine("select <s> to sort booklist by title");
            Console.WriteLine("select <f> to find a book");
            Console.WriteLine("select <e> to exit");




            //string search;
            string search;
            string selection = Console.ReadLine();




            do {
               switch (selection)
             {
                        case "a":
                        Console.Clear();
                        Book book2 = new Book();
                        Console.WriteLine("what is the name of the book?");
                        book2.title = Console.ReadLine();
                        Console.WriteLine("who is the author of the book?");
                        book2.author = Console.ReadLine();
                        Console.WriteLine("What is the ISBN of the book?");
                        book2.ISBN = Console.ReadLine();
                        Console.WriteLine("What is the price of the book?");
                        book2.price = Convert.ToInt64(Console.ReadLine());
                        
                        //need to add a exception for price to check for .decimal or floats or try parse float and set  price type to float.
                        booklist.Add(book2);
                        Console.WriteLine("-Hit Tab to go back to main menu");
                        selection = Console.ReadLine();

                        continue;

                        case "d":
                            Console.Clear();
                            Console.WriteLine("Here is the complete booklist");
                            Book.displayList(booklist);
                            Console.WriteLine("-Hit Tab to go back to main menu");
                            selection = Console.ReadLine();
                            break;

                    case "f":
                        Console.Clear();
                        Console.WriteLine("Can you provide the ISBN Number of the book?");
                        search = Console.ReadLine();
                        Book.searchList(booklist, search);
                        selection = Console.ReadLine();
                        break;
                   // has to be an exact match of ISBN nee to test a  "contains" statement in method not first or default

                    case "s":
                        Console.Clear();
                        Console.WriteLine("here is the sorted book list by title?");
                        Book.sortList(booklist);
                        selection = Console.ReadLine();
                        break;


                    case "e":
                            Console.Clear();
                            Console.WriteLine("Thanks for using the system");

                    break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Menu Options for Booklist");
                        Console.WriteLine("select <a> to add a book");
                        Console.WriteLine("select <d> display book");
                        Console.WriteLine("select <s> to sort booklist");
                        Console.WriteLine("select <f> to find a book");
                        Console.WriteLine("select <e> to exit");
                        selection = Console.ReadLine();
                        break;
                }

            } while (selection != "e");

            

            Console.ReadLine();
        }


      

        class Book
        {

            public string title;
            public string author;
            public string ISBN;
            public long price;


            public static void displayList(List<Book> mybooks)
            {

                foreach (Book b in mybooks)
                {
                    Console.WriteLine("title: {0}, Author: {1},  ISBN: {2}, Price: {3}", b.title, b.author, b.ISBN, b.price);
                }
            }

            //public static void addList(Book book, List<Book> booklist)
            //    {

            //       booklist.Add(book);
                     
            //     }

            public static void sortList(List<Book> booklist)

            {
                booklist.Sort((x, y) => x.title.CompareTo(y.title));
                displayList(booklist);
                Console.WriteLine("-Tab any key to go back to main menu");
            }




            public static void searchList(List<Book> booklist, string ISBN)
            {
                var item = booklist.FirstOrDefault(o => o.ISBN == ISBN);
                if (item != null)
                {
                    Console.WriteLine("-WOW, we have your book title here it is {0}", item.title);
                }
                else {

                    Console.WriteLine("Sorry we do not have that in our records");
                }
                Console.WriteLine("Hit Tab to go back to the Main Menu");

                // need to provide answer give there is not 
            }


            //public Book(string title, string author, string ISBN, long price)
            //{
            //    this.title = title;
            //    this.author = author;
            //    this.ISBN = ISBN;
            //    this.price = price;

            //}


        }


    }

}


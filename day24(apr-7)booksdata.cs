using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lynq
{
    class basics5
    {
        public static void Main()
        {
            IList<books> bookdata = new List<books>()
            {
                new books() { bookid =1, authorname = "William Faulkner", title="Absalom, Absalom!",price=450 },
                new books() { bookid =2, authorname = "Eugene O'Neill", title="Ah, Wilderness!",price=150 },
                new books() { bookid =3, authorname = "Robert Penn Warren", title="All the King's Men",price=200 },
                new books() { bookid =4, authorname = "Aldous Huxley", title="Antic Hay",price=500 },
                new books() { bookid =5, authorname = "Michael Moorcock", title="Behold the Man",price=300 },
                new books() { bookid =6, authorname = "Noël Coward", title="Blithe Spirit",price=350 },
                new books() { bookid =7, authorname = "Agatha Christie", title="Butter In a Lordly Dish",price=400 }


            };

            var qry = from task in bookdata
                      select task;


            foreach (var q in qry) 
                Console.WriteLine(q.bookid+"          "+q.authorname+"         "+q.title+"                   "+q.price);



            Console.WriteLine();
            var aqry = from task1 in bookdata
                       where task1.authorname.Contains("Noël Coward")
                       select task1;
            foreach (var names in aqry)
                Console.WriteLine(names.title);

            Console.WriteLine();




            var bqry = from task2 in bookdata
                       orderby task2.price ascending
                       select task2;
            foreach (var task3 in bqry)
                Console.WriteLine(task3.price+"   "+task3.title);




            Console.WriteLine();
            var cqry = from task3 in bookdata
                      orderby task3.authorname ascending
                      select task3;

            foreach (var task3 in cqry)
                Console.WriteLine(task3.authorname + "            "+task3.title+"      ");







        }
    }

    class books
    {
        public int bookid { get; set; }
        public string authorname { get; set; }

        public string title { get; set; }
        public int price { get; set; }
    }

}

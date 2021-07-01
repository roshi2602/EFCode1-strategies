using System;
using System.Linq;
using ClassLibrary;
using System.Data.Entity;
using System.Data;
namespace EFCode1Strategies
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new EFContext())
            {
                
                var s = new StudentClass() { name = "ria", salary=25000, qual="btech"};
                ctx.studentClasses.Add(s);

           

                var t = new StudentAdd() {  city = "indore", zipcode = 4582 };
                s.address = t;                     //important
            //   ctx.studentAdds.Add(t);
               
                ctx.SaveChanges();


                //display data using query
                //    var query = from x in ctx.studentClasses orderby x.id, x.name,x.salary select x;
                //line 28 or 30
                var lst = ctx.studentClasses.ToList();
                Console.WriteLine("display data");
                //access qu
                foreach(var e in lst)
                {
                    Console.WriteLine(e.name,e.salary,e.id);
                }

                var mst = ctx.studentAdds.ToList();
                foreach (var e in mst)
                {
                    Console.WriteLine(e.city,e.zipcode);
                }

                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}

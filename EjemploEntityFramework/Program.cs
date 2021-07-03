using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            using (EjemploEntityFramework db = new EjemploEntityFramework())
            {
                // INSERT
                /*
                gente oGente = new gente();
                oGente.nombre = "Miguel";
                oGente.edad = 29;
                oGente.idsexo = 1;

                db.gente.Add(oGente);
                db.SaveChanges();
                */



                // UPDATE
                /*
                gente oGente = db.gente.Where(d => d.nombre == "Ana").First();

                oGente.edad = 30;

                db.Entry(oGente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                */



                // DELETE
                /*
                gente oGente = db.gente.Find(2);

                db.gente.Remove(oGente);
                db.SaveChanges();
                */

                // INSERT CON PROCEDIMIENTO ALMACENADO
                /*
                db.insertarGente("Alejandra", 23, 2);
                db.SaveChanges();
                */


                // SELECT - VIEW
                var lst = db.gente;
                foreach (var oGente_ in lst)
                {
                    Console.WriteLine(oGente_.nombre);
                }
                Console.Read();
            }
        }
    }
}

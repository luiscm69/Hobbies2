using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HobbiesServices.Persistencia
{
    public class HobbyDAO
    {
        public void registrarHobby(hobby hobbyEntity)
        {
            using (var db = new MySqlEntities())
            {
                db.hobbies.AddObject(hobbyEntity);
                db.SaveChanges();
            }
        }

        public List<string> ListarHobbies()
        {
            using (var db = new MySqlEntities())
            {
                var resultado = from l in db.hobbies select l.descripcion;
                return resultado.ToList();
            }
        }

    }
}
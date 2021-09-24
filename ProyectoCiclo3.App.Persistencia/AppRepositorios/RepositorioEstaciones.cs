using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones; 
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Plaza central",direccion= "Av americas",coord_x= 100000,coord_y= 4,Tipo= "Trasmilenio"},
                new Estaciones{id=2,nombre="Museo del oro",direccion= "Carrera 7",coord_x= 90000,coord_y= 16,Tipo= "Sitp"},
                new Estaciones{id=3,nombre="Las flores",direccion= "Av caracas",coord_x= 150000,coord_y= 24,Tipo= "Mixta"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetEstacionWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }
    }
}

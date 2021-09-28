using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas; 
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen=101,destino= 201,tiempo_estimado= 30},
                new Rutas{id=2,origen=102,destino= 202,tiempo_estimado= 40},
                new Rutas{id=3,origen=103,destino= 203,tiempo_estimado= 50}
                
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutaWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }

        public Rutas Update(Rutas newRuta){
            var ruta = rutas.SingleOrDefault(b => b.id == newRuta.id);
            if (ruta != null)
                {
                    ruta.origen= newRuta.origen;
                    ruta.destino= newRuta.destino;
                    ruta.tiempo_estimado= newRuta.origen;
                }
            return ruta;
        }
    }
}
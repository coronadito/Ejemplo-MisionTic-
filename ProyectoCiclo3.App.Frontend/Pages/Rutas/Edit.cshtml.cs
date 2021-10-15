using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
using Microsoft.AspNetCore.Authorization;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    [Authorize]
   public class EditRutaModel : PageModel
    {
        private readonly RepositorioEstaciones repositorioEstaciones;
        public IEnumerable<Estaciones> Estaciones {get;set;}

        private readonly RepositorioRutas repositorioRutas;
              [BindProperty]
              public Rutas Ruta {get;set;}
 
        public EditRutaModel(RepositorioRutas repositorioRutas, RepositorioEstaciones repositorioEstaciones)
       {
            this.repositorioRutas=repositorioRutas;
            this.repositorioEstaciones=repositorioEstaciones;
       }
 
        public IActionResult OnGet(int rutaId)
        {
                Ruta=repositorioRutas.GetRutaWithId(rutaId);
                Estaciones=repositorioEstaciones.GetAll();
                return Page();
                
 
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Ruta.id>0)
            {
                Ruta = repositorioRutas.Update(Ruta);
            }
            return RedirectToPage("./List");
        }
    }
}

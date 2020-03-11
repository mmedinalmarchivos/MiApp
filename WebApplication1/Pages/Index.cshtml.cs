using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication1.DBContext;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {

        private readonly PruebaDBContext _pruebaDBContext;


        [BindProperty]
        public string MensajeInicio { get; set; }

        [BindProperty]
        public string Mensaje1 { get; set; }

        [BindProperty]
        public ObservableCollection<string> Mensajes { get; set; }

        public IndexModel()
        {
            MensajeInicio = "Inicio";
            Mensajes = new ObservableCollection<string>(new List<string>());
            Mensajes.Add("1");
            Mensajes.Add("2");
            Mensajes.Add("3");
            Mensajes.Add("4");
            Mensajes.Add("5");
        }

        public void OnGet()
        {
        }

        public void OnPostMostrarMensaje1()
        {
            //Mensaje1 = "Mensaje 1";
        }

        public void OnPostMostrarMensaje2()
        {
           // Mensaje2 = "Mensaje 2";
        }
    }
}

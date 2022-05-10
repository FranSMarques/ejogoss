using System;
using EJOGOSS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOSS.Controllers
{
    public class EquipeController : Controller
    {


        //ActionResult representam os vários códigos HTTP

        //Códigos HTTP - https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status

        Equipe equipeModel = new Equipe();

        public object ViewBag { get; private set; }

        public IActionResult Index()

        {

            //ViewBag = Reserva de espaço para armazenar informações para recuperar na VIEW

            //ViewBag = tem a função de "carregar" as informações do Controller para a VIEW

            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();

        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}

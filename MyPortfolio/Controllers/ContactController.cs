using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;
using System;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string contactName, string contactEmail, string contactSubject, string contactMessage)
        {
            var msg = new Message
            {
                NameSurname = contactName,
                Email = contactEmail,
                Subject = contactSubject,
                MessageDetail = contactMessage,
                SendDate = DateTime.Now,
                IsRead = false
            };

            context.Messages.Add(msg);
            context.SaveChanges();

            TempData["Success"] = "Mesajınız başarıyla gönderildi!";
            return RedirectToAction("Index", "Default");
        }
    }
}

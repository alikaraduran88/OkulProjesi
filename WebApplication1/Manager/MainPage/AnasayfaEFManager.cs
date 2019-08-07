using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Manager.MainPage
{
    public class AnasayfaEFManager : AnasayfaService
    {
        PROJEEntities1 PROJEEntities = new PROJEEntities1();
        public List<Duyurular> GetAllDuyurular()
        {
            return PROJEEntities.Duyurulars.ToList();
        }
    }
}
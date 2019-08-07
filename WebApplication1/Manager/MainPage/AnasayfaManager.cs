using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Manager.MainPage
{
    public class AnasayfaManager : AnasayfaService
    {
        PROJEEntities db = new PROJEEntities();
        public List<Duyurular> GetAllDuyurular()
        {
            return db.Duyurular.ToList();
        }
    }
}
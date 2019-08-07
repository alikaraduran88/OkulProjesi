using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Data;

namespace WebApplication1.Manager.MainPage
{
    public interface AnasayfaService
    {
        List<Duyurular> GetAllDuyurular();
    }
}
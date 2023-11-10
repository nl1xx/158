using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Main()
        {
            MainCityInfo mainCityInfo = new MainCityInfo();
            mainCityInfo.id = new int[3];
            mainCityInfo.name = new string[3];
            mainCityInfo.description = new string[3];
            for (int i = 0; i < 3; i++)
            {
                mainCityInfo.id[i] = i;
                switch (i)
                {
                    case 0:
                        mainCityInfo.name[i] = "Beijing";
                        mainCityInfo.description[i] =
                            "Beijing is the capital of China and is located in the northern part of the North China Plain." +
                            " As an ancient capital with a history of more than 3,000 years, Beijing blends a long cultural " +
                            "heritage with a modern urban charm. The city is home to Tiananmen Square, the world's largest " +
                            "city square, and the Forbidden City, the world's best-preserved complex of ancient royal palaces.";
                        break;
                    case 1:
                        mainCityInfo.name[i] = "Tianjin";
                        mainCityInfo.description[i] =
                            "Tianjin is a tourist attraction and commercial center that blends Chinese and Western cultures," +
                            " historical and cultural heritage, and modern cityscape. Tianjin has a rich historical and cultural " +
                            "heritage, such as the Ruyi Garden, the Ancient Culture Street and the Dagukou Fort. There are also" +
                            " a variety of modern buildings and attractions, such as the Tianjin Eye Observation Wheel.";
                        break;
                    case 2:
                        mainCityInfo.name[i] = "New Zealand";
                        mainCityInfo.description[i] =
                            "Travel around New Zealand and experience its pristine wilderness and diverse culture. Find inspiration" +
                            " in the towering mountains and mist-shrouded fjords; Stroll on the golden sand beach and feel the tranquility of" +
                            " the bay surrounded on all sides; Meet new people and spend quality time together in a laid-back town.";
                        break;
                }
            }
            return View(mainCityInfo);
        }
    }
}
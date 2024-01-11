using consumeAPI_SUN.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace consumeAPI_SUN.Controllers
{
    public class FoodController : Controller
    {        

        [HttpGet]
        public ActionResult GetFoodInfo()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> GetFoodInfo(int num ,string unit, string name)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    HttpResponseMessage response = await client.GetAsync($"https://api.edamam.com/api/nutrition-data?app_id=68f57d61&app_key=%207a5f77e09863df370a83b7523d9c6c90&nutrition-type=cooking&ingr={num}%20{unit}%20{name}");
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        FoodInfo foodInfo = JsonConvert.DeserializeObject<FoodInfo>(apiResponse);

                        return View(foodInfo);
                    }
                    else
                    {
                        ViewBag.Error = "Failed to fetch food information";
                        return View();
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View();
            }
        }
      
    }
}
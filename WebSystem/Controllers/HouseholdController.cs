using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebSystem.Helper;
using WebSystem.Models;

namespace WebSystem.Controllers
{
    public class HouseholdController : Controller
    {
        HelperAPI _api = new HelperAPI();
        public async Task<IActionResult> Index(int pg = 1)
        {
            List<Household> households = new List<Household>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/household");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                households = JsonConvert.DeserializeObject<List<Household>>(results);
            }

            const int pageSize = 10;
            if (pg < 1)
                pg = 1;

            int recsCount = households.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = households.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            //return View(households);
            return View(data);
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            HttpClient client = _api.Initial();

            if (id == 0)
                return View(new Household());
            else
            {
                HttpResponseMessage res = client.GetAsync("api/household/" + id.ToString()).Result;
                return View(res.Content.ReadAsAsync<Household>().Result);
            }
            
        }
        
        [HttpPost]
        public IActionResult AddOrEdit(Household household)
        {
            HttpClient client = _api.Initial();

            ////HTTP POST
            //var postTask = client.PostAsJsonAsync<Household>("api/household", household);
            //postTask.Wait();

            //var result = postTask.Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    TempData["SuccessMessage"] = "Data Tersimpan";
            //    //household.CreatedDate = DateTime.Now;
            //    return RedirectToAction("Index");
            //}
            //return View();

            //if (household.HouseholdId == 0)
            //{                
            //    RedirectToAction("Calculate");
            //}
            //else
            //{
            //    HttpResponseMessage res = client.PutAsJsonAsync("api/household/" + household.HouseholdId, household).Result;
            //    TempData["SuccessMessage"] = "Data telah diperbaharui";
            //}
            //return RedirectToAction("Index");

            if (household.HouseholdId == 0)
            {
                HttpResponseMessage res = client.PostAsJsonAsync("api/household", household).Result;
                TempData["SuccessMessage"] = "Data telah disimpan";
            }
            else
            {
                HttpResponseMessage res = client.PutAsJsonAsync("api/household/" + household.HouseholdId, household).Result;
                TempData["SuccessMessage"] = "Data telah diperbaharui";
            }
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int id)
        {
            var household = new Household();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/household/{id}");
            //HttpResponseMessage res = await client.DeleteAsync("api/household/" + id.ToString()).Result;

            TempData["SuccessMessage"] = "Data telah dihapus";
            return RedirectToAction("Index");
        }

        //public IActionResult Calculate(Household household)
        //{
        //    HttpClient client = _api.Initial();
            
        //    var konsumsilistrik = household.KonsumsiListrik().ToString();
        //    var konsumsigas = household.KonsumsiGas().ToString();
        //    var emisicolistrik = household.EmisiCo2Listrik().ToString();
        //    var emisicogas = household.EmisiCo2Gas().ToString();
        //    var emisicoperson = household.EmisiCo2Person().ToString();

        //    ViewBag.konsumsilistrik = konsumsilistrik;
        //    ViewBag.konsumsigas = konsumsigas;
        //    ViewBag.emisicolistrik = emisicolistrik;
        //    ViewBag.emisicogas = emisicogas;
        //    ViewBag.emisicoperson = emisicoperson;

            
            
        //    return View();
        //}

    }
}

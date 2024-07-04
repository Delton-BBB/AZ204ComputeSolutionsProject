using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace WeatherAPI.Controllers
{
    [Route("weatherapi")]
    public class WeatherAPIController : Controller
    {
        WeatherAPIService _weatherAPIService;

        public WeatherAPIController() { 
            _weatherAPIService = new WeatherAPIService();
        }

        // GET: WeatherAPIController
        [Route("current/{postcode}")]
        public async Task<ActionResult> GetCurrentTemp(string postcode)
        {
            string jsonRes = await _weatherAPIService.GetCurrentWeatherByPostCode(postcode);

            return Ok(jsonRes);
        }

/*        [Route("get")]
        // GET: WeatherAPIController/Details/5
        public ActionResult (int id)
        {
            return Ok("get");
        }*/


/*
        // GET: WeatherAPIController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherAPIController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WeatherAPIController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WeatherAPIController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WeatherAPIController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WeatherAPIController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}

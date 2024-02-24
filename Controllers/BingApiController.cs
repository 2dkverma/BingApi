using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;

namespace BingApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BingApiController : ControllerBase
{
 
    [HttpGet(Name = "GetBingApi/{LocationName?}")]
    public async Task<IActionResult> Get(string? LocationName)
    {
        if (String.IsNullOrWhiteSpace(LocationName) )
            return Ok(new List<string>());
       
        var startTime = new DateTime(1900,01,01,10,00,00);
        var endTime = new DateTime(1900,01,01,13,00,00);

        List<BingApi> data= new List<BingApi>();
         data.Add(new BingApi(1,"Kolkata", new DateTime(1900,01,01,10,00,00),new DateTime(1900,01,01,13,00,00)));
         data.Add(new BingApi(2,"New Delhi",  new DateTime(1900,01,01,06,00,00),new DateTime(1900,01,01,16,00,00)));
         data.Add(new BingApi(3,"Haryana", new DateTime(1900,01,01,08,00,00),new DateTime(1900,01,01,10,00,00)));
         data.Add(new BingApi(4,"Punjab",  new DateTime(1900,01,01,10,30,00),new DateTime(1900,01,01,12,49,00)));
         data.Add(new BingApi(5,"Lucknow",  new DateTime(1900,01,01,12,00,00),new DateTime(1900,01,01,22,00,00)));
         data.Add(new BingApi(6,"Pune",  new DateTime(1900,01,01,10,00,00),new DateTime(1900,01,01,13,00,00)));
         data.Add(new BingApi(7,"Jaipur",  new DateTime(1900,01,01,11,00,00),new DateTime(1900,01,01,19,00,00)));
         data.Add(new BingApi(8,"Hyderabad", new DateTime(1900,01,01,10,10,10),new DateTime(1900,01,01,12,00,00)));
         data.Add(new BingApi(9,"Chandigarah", new DateTime(1900,01,01,10,10,00),new DateTime(1900,01,01,13,00,00)));
         data.Add(new BingApi(10,"Patna",  new DateTime(1900,01,01,11,00,00),new DateTime(1900,01,01,12,00,00)));

        var response=  data.Where(x=> x.LocationName.ToLower().Contains(LocationName.ToLower()) && x.OpeningTime >= startTime &&  x.EndingTime <= endTime).Select(x=>x) .ToList();
        if(response.Count > 0)
        {
            return Ok( response);
        }
        return  Ok(new List<string>()) ;

    }
}

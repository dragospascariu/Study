using Microsoft.AspNetCore.Mvc;
using WordPrediction.DbConnection;
using WordPrediction.Service;



namespace WordPrediction.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class ApiController : ControllerBase
    {
        [HttpGet, Route("Backend")]
        public IActionResult DbGet(string text, string locale)
        {
            var dbConnection = new DatabaseConnection();
            var result = dbConnection.GetPredictionsForWord(text);
            var webService = new WebPredictionService();
            var webServiceResult = webService.GetWizkidsWordPrediction(text, locale).Result;
            var mergedResult = new[] { (object)result, (object)webServiceResult};
            return Ok(mergedResult);
        }
    }
}

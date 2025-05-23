using Microsoft.AspNetCore.Mvc;

namespace StrollBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionsController : ControllerBase
    {
        private static List<SessionResult> _mockResults = new List<SessionResult>
        {
            new SessionResult
            {
                Id = 1,
                PrescriptionId = 1,
                SessionDate = DateTime.UtcNow.AddDays(-2),
                PatientName = "Adam Ameen",
                Feedback = "Patient performed well. Slight imbalance noted."
            },
            new SessionResult
            {
                Id = 2,
                PrescriptionId = 2,
                SessionDate = DateTime.UtcNow.AddDays(-1),
                PatientName = "Bishrul Ameen",
                Feedback = "Skipped some exercises. Recommend follow-up."
            }
        };

        [HttpGet]
        public IActionResult GetResults()
        {
            return Ok(_mockResults);
        }

        [HttpPost]
        public IActionResult AddResult([FromBody] SessionResult newResult)
        {
            newResult.Id = _mockResults.Count + 1;
            newResult.SessionDate = DateTime.UtcNow; // Auto set date
            _mockResults.Add(newResult);
            return Ok(newResult);
        }
    }

    public class SessionResult
    {
        public int Id { get; set; }
        public int PrescriptionId { get; set; }

        public string PatientName { get; set; }
        public DateTime SessionDate { get; set; }
        public string Feedback { get; set; } = string.Empty;
    }
}

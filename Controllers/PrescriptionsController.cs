using Microsoft.AspNetCore.Mvc;

namespace StrollBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrescriptionsController : ControllerBase
    {
        private static List<Prescription> _mockPrescriptions = new List<Prescription>
        {
            new Prescription { Id = 1, PatientName = "Adam Ameen", Exercises = new List<string> { "Squats x 3 - every 20 minutes", "Rotate arms x 4 - every 1 hour (each arm)" } },
            new Prescription { Id = 2, PatientName = "Bishrul Ameen", Exercises = new List<string> { "Stretch legs x 3 - every 20 minutes (each leg)", "Arm Circles x 4 - every 1 hour (each arm)" } }
        };

        [HttpGet]
        public IActionResult GetPrescriptions()
        {
            return Ok(_mockPrescriptions);
        }

        [HttpPost("/api/AddPrescription")]
        public IActionResult AddPrescription([FromBody] Prescription newPrescription)
        {
            newPrescription.Id = _mockPrescriptions.Count + 1;
            _mockPrescriptions.Add(newPrescription);
            return Ok(newPrescription);
        }
    }

    public class Prescription
    {
        public int Id { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public List<string> Exercises { get; set; } = new List<string>();
    }
}

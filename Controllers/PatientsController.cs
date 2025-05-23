using Microsoft.AspNetCore.Mvc;

namespace StrollBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private static List<Patient> _mockPatients = new List<Patient>
        {
            new Patient
            {
                Id = 1,
                Name = "Adam Ameen",
                Email = "adamameen5@gmail.com"
            },
            new Patient
            {
                Id = 2,
                Name = "Bishrul Ameen",
                Email = "bishmeen5@gmail.com"
            },
        };

        //get all patients
        [HttpGet]
        public IActionResult GetPatients()
        {
            return Ok(_mockPatients);
        }

        [HttpPost]
        public IActionResult AddPatient([FromBody] Patient newPatient)
        {
            newPatient.Id = _mockPatients.Count + 1;
            _mockPatients.Add(newPatient);
            return Ok(newPatient);
        }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

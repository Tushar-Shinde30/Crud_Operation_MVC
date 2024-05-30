using Aarohi_Crud_Operation.Data;
using Aarohi_Crud_Operation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aarohi_Crud_Operation.Controllers
{
    public class CandidateController : Controller
    {
        private readonly CandidateDbContext _candidateDbContext;

        public CandidateController(CandidateDbContext candidateDbContext)
        {
            _candidateDbContext = candidateDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Candidate candidate)
        {

            return View(candidate);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Egyptian_eInvoicing.ViewModels;
using Egyptian_eInvoicing.Models;
using Egyptian_eInvoicing.Data;
using AutoMapper;


namespace Egyptian_eInvoicing.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public InvoiceController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(InvoiceCreationViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            return RedirectToAction("Index", "Home"); 

        }
    }
}

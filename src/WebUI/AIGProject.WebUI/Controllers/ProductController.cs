using AIGProject.Application.Interfaces.IRepository;
using AIGProject.WebUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AIGProject.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepo;
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;
        public ProductController(IProductRepository productRepo, ILogger<ProductController> logger, IMapper mapper)
        {
            _productRepo = productRepo;
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var data = _productRepo.GetAll();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

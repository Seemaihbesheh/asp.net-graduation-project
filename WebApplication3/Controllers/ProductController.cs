using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using WebApplication3.DBContext;
using WebApplication3.Models;
using WebApplication3.Models.DTO;
using WebApplication3.Repository.Abastract;


namespace WebApplication3.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IFileService _fileService;
        private readonly IProductRepository _productRepo;
        public ProductController(IFileService fs, IProductRepository productRepo)
        {
            this._fileService = fs;
            this._productRepo = productRepo;
        }
        [HttpPost]
        public IActionResult Add([FromForm] Product model)
        {
            var status = new Status();
            if (!ModelState.IsValid)
            {
                status.StatusCode = 0;
                status.Message = "Please pass the valid data";
                return Ok(status);
            }
            if (model.ImageFile != null)
            {
                var fileResult = _fileService.SaveImage(model.ImageFile);
                if (fileResult.Item1 == 1)
                {
                    model.ProductImage = fileResult.Item2; // getting name of image
                    model.FileDisplayName = model.ImageFile.FileName;

                }
                var productResult = _productRepo.AddProduct(model);
                if (productResult)
                {
                    status.StatusCode = 1;
                    status.Message = "Added successfully";
                }
                else
                {
                    status.StatusCode = 0;
                    status.Message = "Error on adding product";

                }
            }
            return Ok(status);

        }


        public IActionResult GetAll()
        {
            return Ok(_productRepo.GetAllProducts());
        }

    }



}

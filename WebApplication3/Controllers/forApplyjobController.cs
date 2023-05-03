using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication3.Models.DTO;
using WebApplication3.Repository.Abastract;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("forApplyjob")]
    public class forApplyjobController : Controller
    {
        private IWebHostEnvironment _environment;
        private readonly IFileService _fileService;
        private readonly IProductRepository _productRepo;
        private readonly DataContext _context;


        public forApplyjobController(IFileService fs, IProductRepository productRepo, DataContext context, IWebHostEnvironment environment)
        {
            _fileService = fs;
            _productRepo = productRepo;
            _context = context;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> Search()
        {
            var data = _context.applyJobs.ToList();
            return Ok(data);
        }


        [HttpGet("GetapplyJob")]
        public async Task<IActionResult> GetApplyJob()
        {
            /* try
             {*/
            var data = _context.applyJobs.Include(x => x.pushJob).ToList();

            // var path = GetFilePath();
            var baseUri = $"{Request.Scheme}://{Request.Host}";

            data.ForEach(t => t.ProductImage = Path.Combine(baseUri,"applyJobFileUploads", t.ProductImage));

            return Ok(data);
            //}

            /*   catch (Exception ex)
               {
                   throw ex;
               }*/
        }



        [HttpGet("GetpushJob")]
        public async Task<IActionResult> GetPushJob()
        {
            try
            {
                var data = _context.pushJobs.ToList();
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("apply")]
        public IActionResult Add([FromForm] applyJob model)
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
                var productResult = _productRepo.AddApplyJob(model);

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

       

        [HttpPost("jobs")]
        public IActionResult PostData([FromBody] pushJob data)
        {
            try
            {
                // Add the received data to the database
                _context.pushJobs.Add(data);
                _context.SaveChanges();

                // Return a success response
                return Ok("Data added successfully to pushJob");
            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }

        public IActionResult GetAll()
        {
            return Ok(_productRepo.GetAllApplyJobs());
        }

    }
}



using GroupDocs.Search.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApplication3.Models.DTO;
using WebApplication3.Repository.Abastract;
using GroupDocs.Search;
using GroupDocs.Search.Common;
using GroupDocs.Search.Highlighters;
using System.Linq;

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
            
            var data = _context.applyJobs.Include(x => x.pushJob).ToList();

            
            var baseUri = $"{Request.Scheme}://{Request.Host}";

            data.ForEach(t => t.ProductImage = Path.Combine(baseUri, "applyJobFileUploads", t.ProductImage));

            return Ok(data);
           
        }



        //here i will send {id}of company 
        [HttpGet("GetapplyJob/{id}")]
       public async Task<ActionResult<applyJob>> GetApplyJobbyid(int id)
        {
            if (_context.applyJobs == null)
            {
                return NotFound();
            }

            //       var Companyy = await _context.applyJobs.FindAsync(id);
          //  var appllyy = await _context.applyJobs.FindAsync(id).Include(x => x.pushJob).ToList();
            var appllyy = await _context.applyJobs.Include(x => x.pushJob).FirstOrDefaultAsync(x => x.Id == id);


            if (appllyy == null)
            {
                return NotFound();
            }
         //   var baseUri = $"{Request.Scheme}://{Request.Host}";

          //  data.ForEach(t => t.ProductImage = Path.Combine(baseUri, "applyJobFileUploads", t.ProductImage));

            return appllyy;

        }




  






        /*
      
        [HttpGet("GetapplyJob/{searchValue}")]
        public async Task<IActionResult> GetApplyJob(string? searchValue)
        {
            var search = searchValue?.ToLower();
            var data = new List<applyJob>();
           
            if (search.IsNullOrEmpty())
            {
                data = _context.applyJobs.Include(x => x.pushJob).ToList();
            } else
            {
                data = _context.applyJobs.Where(t =>
               t.Full_Name.ToLower().Contains(search)
                t.Email.ToLower().Contains(search) ||
                t.City.ToLower().Contains(search) ||
               (t.FileDisplayName != null && t.FileDisplayName.ToLower().Contains(search))
              )

    .Include(x => x.pushJob).ToList();

            }

          
            var baseUri = $"{Request.Scheme}://{Request.Host}";

            data.ForEach(t => t.ProductImage = Path.Combine(baseUri,"applyJobFileUploads", t.ProductImage));

            return Ok(data);
           
        }
        */




        [HttpGet("GetapplyJobCv/{searchValue}")]
        public async Task<IActionResult> GetApplyJobCv(string? searchValue)
        {
            var search = searchValue?.ToLower();
            var data = new List<applyJob>();

            if (search.IsNullOrEmpty())
            {
                data = _context.applyJobs.Include(x => x.pushJob).ToList();
            }
            else
            {
                data = _context.applyJobs.Where(t =>
                 (t.FileDisplayName != null && t.FileDisplayName.ToLower().Contains(search))

              )

    .Include(x => x.pushJob).ToList();

            }


            var baseUri = $"{Request.Scheme}://{Request.Host}";

            data.ForEach(t => t.ProductImage = Path.Combine(baseUri, "applyJobFileUploads", t.ProductImage));

            return Ok(data);

        }


        [HttpGet("GetapplyJobName/{searchValue}")]
        public async Task<IActionResult> GetApplyJobName(string? searchValue)
        {
            var search = searchValue?.ToLower();
            var data = new List<applyJob>();

            if (search.IsNullOrEmpty())
            {
                data = _context.applyJobs.Include(x => x.pushJob).ToList();
            }
            else
            {
                data = _context.applyJobs.Where(t =>
                t.Full_Name.ToLower().Contains(search) 
               
              )

    .Include(x => x.pushJob).ToList();

            }


            var baseUri = $"{Request.Scheme}://{Request.Host}";

            data.ForEach(t => t.ProductImage = Path.Combine(baseUri, "applyJobFileUploads", t.ProductImage));

            return Ok(data);

        }








        [HttpGet("GetapplyJobEmail/{searchValue}")]
        public async Task<IActionResult> GetApplyJobEmail(string? searchValue)
        {
            var search = searchValue?.ToLower();
            var data = new List<applyJob>();

            if (search.IsNullOrEmpty())
            {
                data = _context.applyJobs.Include(x => x.pushJob).ToList();
            }
            else
            {
                data = _context.applyJobs.Where(t =>
                t.Email.ToLower().Contains(search) 

              )

    .Include(x => x.pushJob).ToList();

            }


            var baseUri = $"{Request.Scheme}://{Request.Host}";

            data.ForEach(t => t.ProductImage = Path.Combine(baseUri, "applyJobFileUploads", t.ProductImage));

            return Ok(data);

        }



        [HttpGet("GetapplyJobCity/{searchValue}")]
        public async Task<IActionResult> GetApplyJobCity(string? searchValue)
        {
            var search = searchValue?.ToLower();
            var data = new List<applyJob>();

            if (search.IsNullOrEmpty())
            {
                data = _context.applyJobs.Include(x => x.pushJob).ToList();
            }
            else
            {
                data = _context.applyJobs.Where(t =>
                t.City.ToLower().Contains(search)
              )

    .Include(x => x.pushJob).ToList();

            }


            var baseUri = $"{Request.Scheme}://{Request.Host}";

            data.ForEach(t => t.ProductImage = Path.Combine(baseUri, "applyJobFileUploads", t.ProductImage));

            return Ok(data);

        }




        [HttpGet("GetpushJob")]
        public async Task<IActionResult> GetPushJob()
        {
            try
            {
                //  var data = _context.applyJobs.Include(x => x.pushJob).ToList();
                var data = _context.pushJobs.Include(x => x.company).ToList();
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

        [HttpGet("GetpushJobTitle/{searchValue}")]
        public async Task<IActionResult> GetpushJobTitle(string? searchValue)
        {
            var search = searchValue?.ToLower();
            var data = new List<pushJob>();

            if (search.IsNullOrEmpty())
            {
                data = _context.pushJobs.ToList();
            }
            else
            {
                data = _context.pushJobs.Where(t =>
                t.Title.ToLower().Contains(search)

              )

            .ToList();

            }


            var baseUri = $"{Request.Scheme}://{Request.Host}";


            return Ok(data);

        }



        [HttpGet("GetpushJobCompanyemail/{searchValue}")]
        public async Task<IActionResult> GetpushJobCompanyemail(string? searchValue)
        {
            var search = searchValue?.ToLower();
            var data = new List<pushJob>();

            if (search.IsNullOrEmpty())
            {
                data = _context.pushJobs.ToList();
            }
            else
            {
                data = _context.pushJobs.Where(t =>
                t.Email.ToLower().Contains(search)

              )

            .ToList();

            }


            var baseUri = $"{Request.Scheme}://{Request.Host}";


            return Ok(data);

        }

        [HttpGet("GetpushJobCompanyrequirment/{searchValue}")]
        public async Task<IActionResult> GetpushJobCompanyrequirment(string? searchValue)
        {
            var search = searchValue?.ToLower();
            var data = new List<pushJob>();

            if (search.IsNullOrEmpty())
            {
                data = _context.pushJobs.ToList();
            }
            else
            {
                data = _context.pushJobs.Where(t =>
                t.Requrment.ToLower().Contains(search)

              )

            .ToList();

            }


            var baseUri = $"{Request.Scheme}://{Request.Host}";


            return Ok(data);

        }


        [HttpGet("PdfSearch/{searchValue}")]
        public IActionResult PdfSearch(string? searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
            {
                return BadRequest("empty search value");

            }
            // var path = GetFilePath();
            var baseUri = _environment.WebRootPath;
            var filesPath = new List<string>();

            // Specify path to the index folder
            string indexFolder = @"C:\Files\Index";

            // Specify path to a folder containing PDF documents to search
            string documentsFolder = @"C:\Files\Files";

// create or load an index

var index = new  GroupDocs.Search.Index(indexFolder);

// Subscribe to index events
index.Events.ErrorOccurred += (sender, args) =>
{
    // Writing error messages to the console
    Console.WriteLine(args.Message);
};

// Add files synchronously
// Synchronous indexing documents from the specified folder
index.Add(documentsFolder);

            // Perform search
            string query = searchValue; // Specify a search query
SearchResult result = index.Search(query); // Searching in the index

// Use search results
// Printing the result
Console.WriteLine("Documents found: " + result.DocumentCount);
Console.WriteLine("Total occurrences found: " + result.OccurrenceCount);

for (int i = 0; i < result.DocumentCount; i++)
{
    FoundDocument document = result.GetFoundDocument(i);
                var fileName = Path.GetFileName(document.DocumentInfo.FilePath);
                filesPath.Add(fileName);    

}
            var data = (from job in _context.applyJobs.Where(t=>t.ProductImage != null).Include(x => x.pushJob).AsEnumerable()
                        join path in filesPath on job.ProductImage equals path
                        select job
                        ).ToList();
            //var data = _context.applyJobs.Where(t=>t.ProductImage != null).Where(t => filesPath.Any(file => file.Contains(t.ProductImage))).ToList();
            /*// Highlight occurrences in text
            if (result.DocumentCount > 0)
            {
                // Getting the first found document
                FoundDocument document = result.GetFoundDocument(0);

                string path = documentsFolder + "Highlighted.html";

                // Creating the output adapter to a file
                OutputAdapter outputAdapter = new FileOutputAdapter(path);

                // Creating the highlighter object
                HtmlHighlighter highlighter = new HtmlHighlighter(outputAdapter);

                // Generating output HTML formatted document with highlighted search results
                index.Highlight(document, highlighter); 

                Console.WriteLine();
                Console.WriteLine("Generated HTML file can be opened with Internet browser.");
                Console.WriteLine("The file can be found by the following path:");
                Console.WriteLine(path);
            }*/
            return Ok(data);

        }


    }
}



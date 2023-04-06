using Microsoft.AspNetCore.Mvc;
using PdfSharpCore.Pdf;
using PdfSharpCore;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace WebApplication3.Controllers
{

    [ApiController]

    [Route("Invoice")]

    [Produces("application/json")]
    public class InvoiceController : Controller
    {

        private readonly IInvoiceContainer _container;
        private readonly IWebHostEnvironment environment;
       

        public InvoiceController(IInvoiceContainer container, IWebHostEnvironment webHostEnvironment)
        {
            this._container = container;
            this.environment = webHostEnvironment;
        }

        /*
        [HttpGet("GetAllInvoiceHeader")]
        public async Task<InvoiceEntity> GetByCode(string Code)
        {
            return await this._container.Getbycode(Code);

        }
        */


        [HttpGet("GetAllHeader")]
        public async Task<List<InvoiceHeader>> GetAllHeader()
        {
            return await this._container.GetAllInvoiceHeader();

        }



        [HttpGet("GetAllHeaderbyCode")]
        public async Task<InvoiceHeader> GetAllHeaderbyCode(string invoiceno)
        {
            return await this._container.GetAllInvoiceHeaderbyCode(invoiceno);

        }


        [HttpGet("generatepdf")]
        public async Task<IActionResult> GeneratePDF(string InvoiceNo)
        {
            var document = new PdfDocument();
            string imgeurl = "data:image/png;base64, " + Getbase64string() + "";

            string[] copies = { "Customer copy", "Comapny Copy" };
            for (int i = 0; i < copies.Length; i++)
            {
                InvoiceHeader header = await this._container.GetAllInvoiceHeaderbyCode(InvoiceNo);
              //List<InvoiceDetail> detail = await this._container.GetAllInvoiceDetailbyCode(InvoiceNo);
                string htmlcontent = "<div style='width:100%; text-align:center'>";
                htmlcontent += "<img style='width:80px;height:80%' src='" + imgeurl + "'   />";
                htmlcontent += "<h2>" + copies[i] + "</h2>";
                htmlcontent += "<h2>Welcome to Nihira Techiees</h2>";



                if (header != null)
                {
                    htmlcontent += "<h2> Invoice No:" + header.InvoiceNo + " & Invoice Date:" + header.InvoiceNo + "</h2>";
                    htmlcontent += "<h3> Customer : " + header.CustomerName + "</h3>";
                    htmlcontent += "<p>" + header.DeliveryAddress + "</p>";
                    htmlcontent += "<h3> Contact : 9898989898 & Email :ts@in.com </h3>";
                    htmlcontent += "<div>";
                }



                htmlcontent += "<table style ='width:100%; border: 1px solid #000'>";
                htmlcontent += "<thead style='font-weight:bold'>";
                htmlcontent += "<tr>";
                htmlcontent += "<td style='border:1px solid #000'> Product Code </td>";
                htmlcontent += "<td style='border:1px solid #000'> Description </td>";
                htmlcontent += "<td style='border:1px solid #000'>Qty</td>";
                htmlcontent += "<td style='border:1px solid #000'>Price</td >";
                htmlcontent += "<td style='border:1px solid #000'>Total</td>";
                htmlcontent += "</tr>";
                htmlcontent += "</thead >";

                htmlcontent += "<tbody>";
               
                htmlcontent += "</tbody>";

                htmlcontent += "</table>";
                htmlcontent += "</div>";

                htmlcontent += "<div style='text-align:right'>";
                htmlcontent += "<h1> Summary Info </h1>";
                htmlcontent += "<table style='border:1px solid #000;float:right' >";
                htmlcontent += "<tr>";
                htmlcontent += "<td style='border:1px solid #000'> Summary Total </td>";
                htmlcontent += "<td style='border:1px solid #000'> Summary Tax </td>";
                htmlcontent += "<td style='border:1px solid #000'> Summary NetTotal </td>";
                htmlcontent += "</tr>";
                if (header != null)
                {
                    htmlcontent += "<tr>";
                    htmlcontent += "<td style='border: 1px solid #000'> " + header.Total + " </td>";
                    htmlcontent += "<td style='border: 1px solid #000'>" + header.Tax + "</td>";
                    htmlcontent += "<td style='border: 1px solid #000'> " + header.NetTotal + "</td>";
                    htmlcontent += "</tr>";
                }
                htmlcontent += "</table>";
                htmlcontent += "</div>";

                htmlcontent += "</div>";

                PdfGenerator.AddPdfPages(document, htmlcontent, PageSize.A4);
            }
            byte[]? response = null;
            using (MemoryStream ms = new MemoryStream())
            {
                document.Save(ms);
                response = ms.ToArray();
            }
            string Filename = "Invoice_" + InvoiceNo + ".pdf";
            return File(response, "application/pdf", Filename);
        }


        [HttpGet("generateaddresspdf")]
        public async Task<IActionResult> generateaddresspdf()
        {
            var document = new PdfDocument();
            List<InvoiceHeader> invoicelist = await this._container.GetAllInvoiceHeader();
            int processcount = 0;
            int breakcount = 0;
            string htmlcontent = String.Empty;
            invoicelist.ForEach(item =>
            {
                htmlcontent += "<div style='width:100%;padding:5px;margin:5px;border:1px solid #ccc'>";
                htmlcontent += "<h1>" + item.CustomerName + " [<b>" + item.InvoiceNo + "</b>]</h1>";
                htmlcontent += "<h2>" + item.DeliveryAddress + "</h2>";
                htmlcontent += "<h2>Payable Amount" + item.NetTotal + "</h2>";
                htmlcontent += "</div>";
                processcount++;
                breakcount++;
                if (breakcount == 4)
                {

                    PdfGenerator.AddPdfPages(document, htmlcontent, PageSize.A4);
                    breakcount = 0;
                    htmlcontent = String.Empty;
                }
                else if (processcount == invoicelist.Count)
                {
                    PdfGenerator.AddPdfPages(document, htmlcontent, PageSize.A4);
                }
            });
            byte[]? response = null;
            using (MemoryStream ms = new MemoryStream())
            {
                document.Save(ms);
                response = ms.ToArray();
            }
            string Filename = "Invoice_Address.pdf";
            return File(response, "application/pdf", Filename);
        }

        [NonAction]
        public string Getbase64string()
        {
            string filepath = this.environment.WebRootPath + "\\Uploads\\common\\logo.jpeg";
            byte[] imgarray = System.IO.File.ReadAllBytes(filepath);
            string base64 = Convert.ToBase64String(imgarray);
            return base64;
        }

    }
}

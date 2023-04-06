using Microsoft.AspNetCore.Mvc;
//using TXTextControl.Web;

namespace WebApplication3.Controllers
{
    [ApiController]

    [Route("cvPDFController")]

    [Produces("application/json")]
    public class cvPDFController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*
      
        [HttpPost]
        public string PDFCreate(string Text)
        {
            byte[] bDocument;

            // create temporary ServerTextControl
            using (TXTextControl.ServerTextControl tx = new TXTextControl.ServerTextControl())
            {
                tx.Create();

                // adding static text
                tx.Text = "This is a sample PDF document.\r\n";

                // insert dynamic text from input field
                TXTextControl.Selection selection = new Selection(-1, 0);
                selection.Text = Text;

                // format selection
                selection.FontSize = 600;
                selection.Bold = true;

                tx.Selection = selection;

                // adding a header
                tx.Sections[1].HeadersAndFooters.Add(HeaderFooterType.Header);
                tx.Sections[1].HeadersAndFooters.GetItem(HeaderFooterType.Header).Selection.Text = "Header";

                // export to PDF
                tx.Save(out bDocument, BinaryStreamType.AdobePDF);
            }

            // return as Base64 encoded string
            return Convert.ToBase64String(bDocument);
        }
        */
       
    }
}

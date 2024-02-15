namespace WebApplication3.Helperrr
{
    public class RejectEmailBody
    {


        public static string EmailStringBody(string email, string emailToken)
        {

            return $@" <html>

            
              <head> </head>
              <body> 

              <div>

              <h1> You can try again later ,</h1>>
          
                <p> 
                We've seen your CV, but we've taken enough applicants to work.
Sorry about that and you can try again later.
               </p>
           

            
              </div>

              </body>
              </html>";
        }




    }
}

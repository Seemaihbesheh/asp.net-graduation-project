
namespace WebApplication3.Helperrr
{
    public static class AcceptEmailBody
    {

        public static string EmailStringBody(string email, string emailToken)
        {

            return $@" <html>

            
              <head> </head>
              <body> 

              <div>

              <h1> Congrats ,</h1>>
          
                <p> 
                Your resume has been reviewed and you have been accepted into our company.
                 You can visit our company headquarters for the rest of the details. 
               </p>
           

            
              </div>

              </body>
              </html>";
        }


    }
}

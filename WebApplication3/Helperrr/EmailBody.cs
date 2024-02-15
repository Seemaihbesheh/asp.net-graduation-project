
using System;


namespace WebApplication3.Helperrr
{
    public  static class EmailBody
    {
   
       public static string EmailStringBody(string email,string emailToken)
      {
         
            return $@" <html>

            
              <head> </head>
              <body> 
              <div>
              <h1> reset you pass noww</h1>>
           

             <p> hi we are reciving this eamil hi we are reciving this eamil hi we are reciving this eamil </p>
             <h1> reset you pass</h1>>
             <h1> hiii      pass </h1>
             <a href=""http://localhost:4200/reset?email={email}&code={emailToken}"" target=""_blank"" style=""background:#0de6efd;padding:10px;border:none;
              width:50%text-align:center;> Reset Passwoord </a> <br>
              <h1> konwww  pass </h1>
              <p> you are recvie this too reset pass /p>
              </div>
              </body>
              </html>";
        }
          
      
    }
}

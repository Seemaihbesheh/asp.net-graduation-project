using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.DBContext;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using NuGet.Packaging.Signing;
using Microsoft.IdentityModel.Tokens;
using System.Net.WebSockets;
using NuGet.Protocol;
using NuGet.Common;
using System.Security.Cryptography;
using WebApplication3.Helperrr;
using NETCore.MailKit.Core;

using WebApplication3.Models;
using Org.BouncyCastle.Bcpg;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;
using WebApplication3.Models.DTO;
using WebApplication3.Models.Repository.Abastract;
//using IEmailService = WebApplication3.UtilityService.IEmailService;

namespace WebApplication3.Controllers
{


    [ApiController]

    [Route("signup")]

    [Produces("application/json")]
    public class signupController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
   


     

       private readonly IEMAILlservice _emailService;
        
      

        public IActionResult Index()
        {
            return View();
        }

     
      public signupController(DataContext context ,IConfiguration configuration, IEMAILlservice emailService)
             // public signupController(DataContext context ,IConfiguration configuration)

        {
        _context = context;
        _configuration = configuration;



       _emailService = emailService;
        }
     

       

        [HttpPost("authenticate")]
        public async Task<ActionResult> Authenticate([FromBody] userU userUobj)

        {
            try
            {
                if (userUobj == null)
                    return BadRequest();

                var userU = _context.userUs.FirstOrDefault(x => x.UserName == userUobj.UserName && x.password == userUobj.password);

                if (userU == null)
                    return NotFound(new { Message = "User not found" });


                userU.Token = CreateJwt(userU);
                return Ok(new
                {
                    Token = userU.Token,
                    Message = " done authenticion login sucess for user!"
                });




            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }


        [HttpPost("authenticateCompany")]
        public async Task<ActionResult> Authenticatecompany([FromBody] Company companyUobj)

        {
            try
            {
                if (companyUobj == null)
                    return BadRequest();

                var companyy = _context.Companys.FirstOrDefault(x => x.UserName == companyUobj.UserName && x.password == companyUobj.password);

                if (companyy == null)
                    return NotFound(new { Message = "User not found" });


                companyy.Token = CreateJwtc(companyy);
                return Ok(new
                {
                    Token = companyy.Token,
                    Message = " done authenticion login sucesss for comapny!"
                });

                


            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }




        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] userU userUobj)

        {
            try
            {


                if (userUobj == null)
                    return BadRequest();


                _context.userUs.Add(userUobj);

                _context.SaveChanges();

                // Return a success response
                return Ok("Data added successfully in register.");
            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }



        [HttpPost("registercompany")]
        public async Task<IActionResult> Registercompany([FromBody] Company companyobj)

        {
            try
            {


                if (companyobj == null)
                    return BadRequest();


                _context.Companys.Add(companyobj);

                _context.SaveChanges();

                // Return a success response
                return Ok("Data added successfully in register company.");
            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }



        private string CreateJwt(userU useru)
        {

            var jwtTokenHanler = new JwtSecurityTokenHandler();


            var key = Encoding.ASCII.GetBytes("verryySercrtttttttttttttttttttttttttttetee");


            var identity = new ClaimsIdentity(new Claim[]
            {

                new Claim(ClaimTypes.NameIdentifier, useru.Id.ToString()),

                new Claim(ClaimTypes.Role ,useru.Role),
                new Claim(ClaimTypes.Name,useru.UserName),
                new Claim(ClaimTypes.Email ,useru.Email),
               



            });


            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            var tokenDecriptor = new SecurityTokenDescriptor
            {

                Subject = identity,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials

            };


           var token = jwtTokenHanler.CreateToken(tokenDecriptor);
            return jwtTokenHanler.WriteToken(token);

        }





        private string CreateJwtc(Company company)
        {

            var jwtTokenHanler = new JwtSecurityTokenHandler();


            var key = Encoding.ASCII.GetBytes("verryySercrtttetee");


            var identity = new ClaimsIdentity(new Claim[]
            {

                new Claim(ClaimTypes.NameIdentifier, company.id.ToString()),

                new Claim(ClaimTypes.Role ,company.Role),
                new Claim(ClaimTypes.Name,company.UserName),
                new Claim(ClaimTypes.Email ,company.Email),




            });


            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            var tokenDecriptor = new SecurityTokenDescriptor
            {

                Subject = identity,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials

            };


            var token = jwtTokenHanler.CreateToken(tokenDecriptor);
            return jwtTokenHanler.WriteToken(token);

        }




        [HttpGet]
        public async Task<ActionResult<IEnumerable<userU>>> GetuserUs()
        {
            if (_context.userUs == null)
            {
                return NotFound();
            }
            return await _context.userUs.ToListAsync();
        }




        [HttpPost("send-reset-email/{email}")]
        public async Task<IActionResult> SendEmail(string email)
        {

            var useru = await _context.userUs.FirstOrDefaultAsync(a => a.Email == email);

            if(useru is null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "email dosen't exit"
                });
            }
            var tokenBytes = RandomNumberGenerator.GetBytes(64);
            var emailToken =Convert.ToBase64String(tokenBytes);
            useru.ResetPasswordToken = emailToken;

       ///     useru.resetpasswordExpiry = DateTime.Now.AddMinutes(15);
            string from = _configuration["EmailSeetings:From"];

            var emailModel = new EmailModel(email, "Reset password!!", EmailBody.EmailStringBody(email, emailToken));
            _emailService.SendEmail(emailModel);
            _context.Entry(useru).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(new
            {
                StatusCode = 200,
                Message = "email sent sucessssss "


           });
        }
      

    

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPassDtoo resetPaswwordDto)
        {
            var newToken = resetPaswwordDto.EmailToken.Replace(" ","+"); //to create new token
            var user = await _context.userUs.AsNoTracking().FirstOrDefaultAsync(a => a.Email == resetPaswwordDto.Email);

            if (user is null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "user dosen't exit"
                });


            }


            var tokenCode = user.ResetPasswordToken;

           // DateTime emailTokenExpiry = (DateTime)user.resetpasswordExpiry;


            if (tokenCode != resetPaswwordDto.EmailToken )
            {

                return BadRequest(new
                {

                    StatusCode = 404,
                    Message = "invalid reset link "
                });
            }



            // user.password = PasswordHasher.HashPassword(resetPaswwordDto.NewPassword);
            user.password = resetPaswwordDto.NewPassword;

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(new
            {
                StatusCode = 200,
                Message = "password reset succefuly"
            });


        }





        [HttpPost("send-accept-email/{email}")]
        public async Task<IActionResult> SendaAcceptEmail(string email)
        {

            var useru = await _context.userUs.FirstOrDefaultAsync(a => a.Email == email);

            if (useru is null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "email dosen't exit"
                });
            }
            var tokenBytes = RandomNumberGenerator.GetBytes(64);
            var emailToken = Convert.ToBase64String(tokenBytes);
            useru.ResetPasswordToken = emailToken;
            
            ///     useru.resetpasswordExpiry = DateTime.Now.AddMinutes(15);
            string from = _configuration["EmailSeetings:From"];

            var emailModel = new EmailModel(email, "Congrats!!! ", AcceptEmailBody.EmailStringBody(email, emailToken));
            _emailService.SendEmail(emailModel);
            _context.Entry(useru).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(new
            {
                StatusCode = 200,
                Message = "email sent sucessssss for accept user "


            });
        }






        [HttpPost("send-delete-email/{email}")]
        public async Task<IActionResult> SendaDeleteEmail(string email)
        {
            
            var useru = await _context.userUs.FirstOrDefaultAsync(a => a.Email == email);

            if (useru is null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "email dosen't exit"
                });
            }
            var tokenBytes = RandomNumberGenerator.GetBytes(64);
            var emailToken = Convert.ToBase64String(tokenBytes);
            useru.ResetPasswordToken = emailToken;

            ///     useru.resetpasswordExpiry = DateTime.Now.AddMinutes(15);
            string from = _configuration["EmailSeetings:From"];

            var emailModel = new EmailModel(email, "Congrats!!! ", AcceptEmailBody.EmailStringBody(email, emailToken));
            _emailService.SendEmail(emailModel);
            _context.Entry(useru).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(new
            {
                StatusCode = 200,
                Message = "email sent sucessssss for accept user "


            });
        }





    }
}



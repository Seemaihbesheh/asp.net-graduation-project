using System;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication3.Models;
namespace WebApplication3.Models.Repository.Abastract
{
    public interface IEMAILlservice
    {

       void SendEmail(EmailModel emailModel);
    }
}

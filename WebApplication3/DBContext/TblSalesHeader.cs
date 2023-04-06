
using System;
using System.Collections.Generic;



using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace WebApplication3.DBContext
{
    public class TblSalesHeader
    {
        [Key]
        public int Id { get; set; }
        public string InvoiceNo { get; set; } = null!;
    
        public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? Remarks { get; set; }
        public decimal? Total { get; set; }
        public decimal? Tax { get; set; }
        public decimal? NetTotal { get; set; }
        public string? CreateUser { get; set; }
      
        public string? ModifyUser { get; set; }
       
    }
}

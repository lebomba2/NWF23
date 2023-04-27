using System.ComponentModel.DataAnnotations;
public class Customer
{
    public int CustomerId { get; set; }
    [Display(Name = "Company Name")]
    [Required]
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    //[Required]
    public string Email { get; set; }
}

//public class BlankCustomer
//{
//    public int CustomerId { get; set; }
//    [Display(Name = "Company Name")]
//    public string CompanyName { get; set; }
//    public string Address { get; set; }
//    public string City { get; set; }
//    public string Region { get; set; }
//    public string PostalCode { get; set; }
//    public string Country { get; set; }
//    public string Phone { get; set; }
//    public string Fax { get; set; }
//    [Required]
//    public string Email { get; set; }
//}

using System.ComponentModel.DataAnnotations;

public class CustomerWithPassword
{
    public Customer Customer { get; set; }
    [UIHint("password"), Required]
    public string Password { get; set; }
}

public class NewCustomer
{
    public int CustomerId { get; set; }
    [Display(Name = "Company Name")]
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}


public class LoginModel
{
    [Required, UIHint("email")]
    public string Email { get; set; }

    [Required, UIHint("password")]
    public string Password { get; set; }
}

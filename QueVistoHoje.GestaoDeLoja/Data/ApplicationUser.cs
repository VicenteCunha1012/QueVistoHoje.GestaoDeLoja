using Microsoft.AspNetCore.Identity;

namespace QueVistoHoje.GestaoDeLoja.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? Nome {  get; set; }
        public string? NIF { get; set; }
        public string? Morada { get; set; }
        public string? Imagem { get; set; }

    }

}

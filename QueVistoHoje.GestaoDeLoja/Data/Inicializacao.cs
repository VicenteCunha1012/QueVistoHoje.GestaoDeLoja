using BlazorGestaoLoja.Data;
using Microsoft.AspNetCore.Identity;
using QueVistoHoje.GestaoDeLoja.Data;

namespace BlazorGestaoLoja.Data
{
    public static class Inicializacao
    {
        public static async Task CriaDadosIniciais(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Adicionar três perfis/roles 
            string[] roles = ["Administrador", "Funcionário", "Cliente"];

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    IdentityRole roleRole = new IdentityRole(role);
                    await roleManager.CreateAsync(roleRole);
                }
            }

            //Adicionar Default User - Admin
            var defaultUser = new ApplicationUser
            {
                UserName = "Admin+01@mail.pt",
                Email = "admin01@mail.pt",
                Nome = "Admin",
                PhoneNumber = "123456789",
                NIF = "123456789",
                Morada ="Rua da rua, numero da casa",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Admin+01"); //password
                    await userManager.AddToRoleAsync(defaultUser, "Administrador"); //role

                }
            }
        }
    }
}

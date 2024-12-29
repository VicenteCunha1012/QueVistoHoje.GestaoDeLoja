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

            //Adicionar Default User - Admin2
            var defaultUser2 = new ApplicationUser
            {
                UserName = "Admin+02@mail.pt",
                Email = "admin02@mail.pt",
                Nome = "Admin2",
                PhoneNumber = "223456789",
                NIF = "223456789",
                Morada = "Rua da rua, numero da casa",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser2.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser2.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser2, "Admin+02"); //password
                    await userManager.AddToRoleAsync(defaultUser2, "Administrador"); //role

                }
            }

            //Adicionar Default User - Funcionario
            var defaultUser3 = new ApplicationUser
            {
                UserName = "Funcionario+01@mail.pt",
                Email = "funcionario01@mail.pt",
                Nome = "Funcionário1",
                PhoneNumber = "123426789",
                NIF = "123456783",
                Morada = "Rua da rua, numero da casa",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser3.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser3.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser3, "Funcionario+01"); //password
                    await userManager.AddToRoleAsync(defaultUser3, "Funcionário"); //role

                }
            }

            //Adicionar Default User - Funcionario
            var defaultUser4 = new ApplicationUser
            {
                UserName = "Funcionario+02@mail.pt",
                Email = "funcionario02@mail.pt",
                Nome = "Funcionário2",
                PhoneNumber = "123426789",
                NIF = "123456783",
                Morada = "Rua da rua, numero da casa",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser4.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser4.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser4, "Funcionario+02"); //password
                    await userManager.AddToRoleAsync(defaultUser4, "Funcionário"); //role

                }
            }
        }
    }
}

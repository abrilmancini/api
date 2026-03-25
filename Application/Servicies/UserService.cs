using System;
using Domain.Entities;

namespace Application.Servicies;

public class UserService
{
    public List<User> GetAllUsers()
    {
        // Lógica para obter todos os usuários
        return new List<User>
        {
            new User { Id = Guid.NewGuid(), Name = "John Doe", Email = "john.doe@example.com", PasswordHash = "" },
            new User { Id = Guid.NewGuid(), Name = "Jane Smith", Email = "jane.smith@example.com", PasswordHash = "" }
        };
    }
}
using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class UserService
{
    private readonly IUserRepository _repo;
    

    public UserService(IUserRepository userRepository)
    {
        _repo = userRepository;
    }

    public List<User> GetAllUsers()
    {
        return _repo.GetAll();
    }

}
using Domain.Entities;
using System;
using System.Collections.Generic;

public static class DummyUserList
{
	public static List<User> Users { get; } = new List<User>
	{
		new User { Id = new Guid("a3c9e2b1-4f2e-4b6a-9c2a-1b2c3d4e5f6a"), Name = "Pablo", Email = "pablo@email.com" },
		new User { Id = new Guid("b2d9e2b1-4f2e-4b6a-9c2a-1b2c3d4e5f6b"), Name = "Ana", Email = "ana@email.com" },
		new User { Id = new Guid("c3e9e2b1-4f2e-4b6a-9c2a-1b2c3d4e5f6c"), Name = "Luis", Email = "luis@email.com" }
	};
}

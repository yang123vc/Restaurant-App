﻿using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Menu.API.Data;
using Menu.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Menu.API.Repositories
{
	[ExcludeFromCodeCoverage]
	public class FoodRepository : RepositoryBase<Food>
	{
		public FoodRepository(ApplicationDbContext context, ILogger<FoodRepository> logger)
			: base(context, logger)
		{
		}

		public override IQueryable<Food> GetAll()
		{
			return base.GetAll().Include(x => x.Category);
		}
	}
}
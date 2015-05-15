﻿using System.Collections.Generic;
using System.Web.Http.Controllers;

namespace Conifer
{
	public interface IConventionalRouter
	{
		IEnumerable<TypedRoute> Routes { get; }
		void AddRoutes<TController>(List<IRouteConvention> conventions) where TController : IHttpController;
	}
}
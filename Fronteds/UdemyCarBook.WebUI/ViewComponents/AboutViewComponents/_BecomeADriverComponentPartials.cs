﻿using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.AboutViewComponents
{
	public class _BecomeADriverComponentPartials : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

using System.Web.Mvc;
using Helpfulcore.Ste.Mvc;
using Sug.Models;

namespace Sug.Controllers
{
	public class TestController : Controller
	{
		private readonly IViewModelFactory viewModelFactory;

		public TestController(IViewModelFactory viewModelFactory)
		{
			this.viewModelFactory = viewModelFactory;
		}

		public ActionResult TestView()
		{
			var viewModel = new TestViewModel(this.viewModelFactory.GetViewModel());

			return this.View(viewModel);
		}
	}
}
namespace Sug.Feature.MyFeature.sitecore
{
	using System;
	using System.Web.UI;
	using Sitecore.Configuration;
	using MyFeature.Examples;
	using Sitecore.DependencyInjection;
	using Microsoft.Extensions.DependencyInjection;

	public partial class Examples : Page
	{
		protected override void OnLoad(EventArgs e)
		{
			var myclass1 = Factory.CreateObject("feature/myfeature/myclass1", false) as MyClass1;
			var myclass2 = Factory.CreateObject("feature/myfeature/myclass2", false) as MyClass2;
			var myclass3 = Factory.CreateObject("feature/myfeature/myclass3", false) as MyClass3;
			var myclass4 = Factory.CreateObject("feature/myfeature/myclass4", false) as MyClass4;
			var myclass5 = Factory.CreateObject("feature/myfeature/myclass5", false) as MyClass5;
			var myclass6 = Factory.CreateObject("feature/myfeature/myclass6", false) as MyClass6;
			var myclass7 = Factory.CreateObject("feature/myfeature/myclass7", false) as MyClass7;
			var myclass8 = Factory.CreateObject("feature/myfeature/myclass8", false) as MyClass8;
			var myclass9 = Factory.CreateObject("feature/myfeature/myclass9", false) as MyClass9;
			var myclass91 = Factory.CreateObject("feature/myfeature/myclass91", false) as MyClass9;

			var myclass81 = ServiceLocator.ServiceProvider.GetService<MyClass8>();

			base.OnLoad(e);
		}
	}
}
using System.Web;
using System.Web.Optimization;

namespace EventReg
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/Libraries/jquery/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/Libraries/jquery/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/Libraries/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/Libraries/bootstrap/bootstrap.js",
					  "~/Scripts/Libraries/respond.js"));

			bundles.Add(new ScriptBundle("~/bundles/angular").Include(
					  "~/Scripts/Libraries/angular/angular.js",
					  "~/Scripts/Libraries/angular/angular-resource.js",
					  "~/Scripts/Libraries/angular/angular-route.js"));

			bundles.Add(new ScriptBundle("~/bundles/eventreg")
				.Include("~/Scripts/App/*.js")
				.Include("~/Scripts/App/controllers/*.js")
				.Include("~/Scripts/App/directives/*.js")
				.Include("~/Scripts/App/filters/*.js")
				.Include("~/Scripts/App/services/*.js")
			);

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/Css/Bootstrap/bootstrap.css",
					  "~/Content/Css/site.css"));

			// Set EnableOptimizations to false for debugging. For more information,
			// visit http://go.microsoft.com/fwlink/?LinkId=301862
			BundleTable.EnableOptimizations = false;
		}
	}
}

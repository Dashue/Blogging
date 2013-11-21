using Nancy;

namespace AngularMenu.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = p =>
                {
                    return View["Index.html"];
                };
        }
    }
}
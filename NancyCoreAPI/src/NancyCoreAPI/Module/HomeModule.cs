using Nancy;

namespace NancyCoreAPI.Module
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello word from nancy module.");
        }
    }
}

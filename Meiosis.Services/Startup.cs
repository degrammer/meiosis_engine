namespace Meiosis.Services
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
                
        }
    }
}

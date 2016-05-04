using Meiosis.Engine;
using Meiosis.Engine.models;
using Newtonsoft.Json;

namespace Meiosis.Services
{
    public class DefaultServices: Nancy.NancyModule
    {
        public DefaultServices()
        {
            ImageEngine imageEngine = new ImageEngine(new LoremPixelProvider());

            Get["/images"] = _ => JsonConvert.SerializeObject(imageEngine.Create(10, null));
        }
    }
}

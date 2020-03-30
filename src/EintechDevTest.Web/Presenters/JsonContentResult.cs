using Microsoft.AspNetCore.Mvc;

namespace EintechDevTest.Web.Presenters
{
    public sealed class JsonContentResult : ContentResult
    {
        public JsonContentResult()
        {
            ContentType = "application/json";
        }
    }
}

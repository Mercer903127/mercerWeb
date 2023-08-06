using mercer_web.Core.SQL;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mercer_web.Core
{
    public class CoreActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null)
            {

            }
            SqlManager.CloseConn();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            SqlManager.OpenConn();
        }
    }
}

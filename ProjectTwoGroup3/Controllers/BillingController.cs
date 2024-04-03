using Microsoft.AspNetCore.Mvc;

namespace ProjectTwoGroup3.Controllers
{
    [ApiController]
    [Route("user/{userId:guid}/[controller]")]
    public class BillingController : ControllerBase
    {
    }
}

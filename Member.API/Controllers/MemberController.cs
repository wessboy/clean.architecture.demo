using Member.Application;
using Microsoft.AspNetCore.Mvc;

namespace Member.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
            
        }

        [HttpGet("all")]
        public ActionResult<IList<Domain.Member>> Get()
        {
            return Ok(_memberService.GetAllMembers());
        }
    }
}

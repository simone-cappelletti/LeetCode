using Microsoft.AspNetCore.Mvc;

namespace LeetCode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeetCodeController : ControllerBase
    {
        private readonly ILogger<LeetCodeController> _logger;
        private readonly ILeetCodeBusiness _leetCodeBusiness;

        public LeetCodeController(
            ILogger<LeetCodeController> logger,
            ILeetCodeBusiness leetCodeBusiness)
        {
            _logger = logger;
            _leetCodeBusiness = leetCodeBusiness;
        }

        [HttpPost]
        public int[] TwoSum(int[] nums, int target)
        {
            _logger.LogInformation(nameof(TwoSum), nums, target);

            var result = _leetCodeBusiness.TwoSum(nums, target);

            return result;
        }
    }
}

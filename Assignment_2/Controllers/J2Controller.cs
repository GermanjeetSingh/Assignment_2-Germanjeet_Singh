using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [ApiController]
    [Route("api/[controller]/DiceGame")]
    // controller gets replaced with filename minus Controller keyword
    public class J2Controller : ControllerBase
    {
        // Example URL : api/J2/DiceGame/4/4
        [HttpGet("{m}/{n}")]
        public string Get(int m, int n)
        {
            int totalWays = 0;
            // Generate all possible combination of dice one
            for (int i = 1; i <= m; i++)
            {
                int leftSum = 10 - i;
                // Check to see if second dice can make the left sum.
                // leftSum > 0 checks that both dices should get rolled 
                if (leftSum > 0 && n >= leftSum)
                {
                    totalWays++;
                }
            }
            if(totalWays == 1)
                return string.Format("There is 1 way to get the sum 10.");
            return string.Format("There are {0} way(s) to get the sum 10.", totalWays);
        }
    }
}

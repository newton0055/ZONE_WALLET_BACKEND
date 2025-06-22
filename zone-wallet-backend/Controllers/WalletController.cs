using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace zone_wallet_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        [HttpPost("create")]

        public async Task<IActionResult> CreateWallet([FromBody] CreateWalletRequestDTO request)
        {
            try
            {
                var response = await _WalletService.CreateWalletAsync(request);
                return Ok(response);
            }
        }
    }
}

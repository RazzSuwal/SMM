using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMM.Data;
using SMM.DataAccessLayer.Services.IServices;
using SMM.Models.DTO;

namespace SMM.Controllers
{
    [Route("api/[[auth]]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly AppDbContext _db;
        protected ResponseDTO _response;

        public UsersController(IAuthService authService, AppDbContext db)
        {
            _authService = authService;
            _response = new();
            _db = db;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDTO model)
        {
            var errorMessage = await _authService.Register(model);
            if(!string.IsNullOrEmpty(errorMessage))
            {
                _response.Success = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            return Ok(_response);
        }
        
        [HttpPost("login")]
        //auth services jo kam ho it is a mistake
        //public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        //{
        //    var user = _db.ApplicationUsers.FirstOrDefault(u=>u.UserName.ToLower()==loginRequestDTO.UserName.ToLower());
        //    bool isValid = await _userManager.CheckPasswordAsync
        //}
    }
}

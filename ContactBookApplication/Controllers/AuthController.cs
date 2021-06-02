using AutoMapper;
using ContactBookApplication.Entities;
using ContactBookApplication.Models;
using ContactBookApplication.Services;
using ContactBookApplication.Services.Interfaces;
using ContactBookApplication.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;


namespace ContactBookApplication.Controllers
{
    [ApiController]
    [Route("api")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly IContactRepository _contactRepository;

        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IAuthRepository _authRepository;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IContactRepository contactRepository, IMapper mapper, IConfiguration configuration, IAuthRepository authRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _contactRepository = contactRepository;
            _mapper = mapper;
            _configuration = configuration;
            _authRepository = authRepository;
        }

     

        
        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterUserDto model)
        {

            // Check if email exist
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                return BadRequest("User already exist");
            }

            // AutoMapper API makes this easier
            var userToAdd = _mapper.Map<User>(model);

            var result = await _userManager.CreateAsync(userToAdd, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest("Cannot create user");
            }

            var newUser = await _userManager.FindByEmailAsync(model.Email);


            await _authRepository.MakeAdmin(newUser);
            await _authRepository.MakeRegular(newUser);

            return Ok(newUser);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto model)
        { 

            var user = await _userManager.FindByEmailAsync(model.Email);



            if (user == null)
            {
                return NotFound();
            }


            var result = await _signInManager.PasswordSignInAsync(user, model.Password, isPersistent: model.RememberMe, false);

            if (!result.Succeeded)
            {
                return NotFound();

            }

            var roles = await _userManager.GetRolesAsync(user);
            //string[] roles = { "Admin" };

            var token = AppUtilities.GenerateToken(user.UserName, user.Email, user.Id, _configuration, roles.ToArray());

           // var token = AppUtilities.GenerateToken(username, model.Email, userId.ToString(), _configuration, roles);

            return Ok(token);
        }



    }
}

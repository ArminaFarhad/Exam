using Eways.Repository;
using Eways.Repository.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eways.Pages;

public class UserModel : PageModel
{
    private readonly ILogger<UserModel> _logger;
    private readonly IUserService _userService;

    public UserModel(ILogger<UserModel> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    public void OnGet()
    {
    }


    public async void OnPost(UserDto userDto)
    {
        await _userService.AddUserAsync(userDto);
    }
}


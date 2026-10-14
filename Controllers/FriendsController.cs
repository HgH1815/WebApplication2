using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class FriendsController : Controller
    {
          
        private readonly FriendsService _friendsService;
        private readonly IMapper _mapper;

        public FriendsController(FriendsService friendsService, IMapper mapper)
        {
            _friendsService = friendsService;
            _mapper = mapper;
        }

        public IActionResult List()
        {
            var friends = _friendsService.GetAll();
            var vm = _mapper.Map<List<FriendViewModel>>(friends);
            return View(vm);
        }

        public IActionResult Detail(int number)
        {
            var friend = _friendsService.GetByNumber(number);
            if (friend == null) return NotFound();
            var vm = _mapper.Map<FriendViewModel>(friend);
            return View(vm);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(FriendViewModel model)
        {
            var friend = _mapper.Map<Friend>(model);
            _friendsService.Add(friend);
            return RedirectToAction("List");
        }

    }
}

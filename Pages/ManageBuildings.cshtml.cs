using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rezerwacja.Data;
using Rezerwacja.Interfaces;
using Rezerwacja.Models;

namespace Rezerwacja.Pages
{
    public class ManageBuildingsModel : PageModel
    {
        [BindProperty]
        public Building Building { get; set; }
        public List<Building> Buildings { get; set; }

        public readonly IRoomService _roomService;

        public ManageBuildingsModel(IRoomService reservationService)
        {
            _roomService = reservationService;
        }
        public void OnGet()
        {
            Buildings = _roomService.GetBuildings();
        }

        public void OnPostAddBuilding() 
        {
            _roomService.AddBuilding(Building);
            Buildings = _roomService.GetBuildings();
        }

        public IActionResult OnPostGoToRooms(int buildID)
        {
            TempData["Building"] = buildID;
            return Redirect("/ManageRooms");
        }
    }
}

using Rezerwacja.Models;
using Rezerwacja.ViewModels;

namespace Rezerwacja.Interfaces
{
    public interface IRoomService
    {
        public List<Building> GetBuildings();
        public void AddBuilding(Building building);


        public List<Room> GetRooms(int buildId);
        public List<Room> GetSearchRooms(SearchVM searchVM);
        public List<RoomVM> GetRoomVMs(int buildId);
        public void AddRoom(Room room);


        public List<Category> GetCategories();
        public List<Equipment> GetEquipment();
        public void checkEq(string eq);
        public void AddCategory(string name);
    }
}

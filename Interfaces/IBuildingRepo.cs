using Rezerwacja.Models;
using Rezerwacja.ViewModels;

namespace Rezerwacja.Interfaces
{
    public interface IBuildingRepo
    {
        public List<Building> GetBuildings();
        public Building GetBuilding(int id);
        public void AddBuilding(Building building);


        public List<Room> GetRooms(int buildID);
        public List<Room> GetSearchRooms(SearchVM searchVM);
        public void AddRoom(Room room);


        public List<Category> GetCategories();
        public List<Equipment> GetEquipment();
        public bool EqExists(string name);
        public void AddEq(string name);
        public bool CatExists(string name);
        public void AddCategory(string name);


        public void AddReservation(Reservation reservation);
        public List<Reservation> GetUserReservations(string userid);
        public List<Reservation> GetApproveReservations();
        public void ApproveReservation(int id);
        public void RemoveReservation(int id);


    }
}

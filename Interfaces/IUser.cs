
using InventorySystem.Models;

namespace InventorySystem.Interfaces
{
    public interface IUser 
    {
        User GetUser(int userId);
    }
}
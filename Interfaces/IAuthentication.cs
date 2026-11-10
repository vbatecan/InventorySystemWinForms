using InventorySystem.Models;

namespace InventorySystem.Interfaces {
    public interface IAuthentication {

        User Login(string username, string password);
    }
}
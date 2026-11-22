namespace InventorySystem.Exceptions {
    public class InvalidLoginDetailsException : Exception{
        public InvalidLoginDetailsException(string message) : base(message)
        {
            
        }
    }
}
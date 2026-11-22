namespace InventorySystem.Exceptions {
    public class FailedCreateUserException : Exception {

        public FailedCreateUserException()
        {
            
        }
        
        public FailedCreateUserException(string message) : base(message)
        {
            
        }
    }
}
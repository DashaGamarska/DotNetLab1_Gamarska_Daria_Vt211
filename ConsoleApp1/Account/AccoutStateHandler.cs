// See https://aka.ms/new-console-template for more information
namespace Account
{
    internal class AccoutStateHandler
    {
        private Action<string> show_Message;

        public AccoutStateHandler(Action<string> show_Message)
        {
            this.show_Message = show_Message;
        }
    }
}
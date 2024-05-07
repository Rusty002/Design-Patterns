namespace Command.Concept
{
    internal class AddCustomerCommand : ICommand
    {
        private readonly CustomerSevice _customerService;

        public AddCustomerCommand(CustomerSevice customerService)
        {
            _customerService = customerService;
        }

        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}

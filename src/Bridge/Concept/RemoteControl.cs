namespace Bridge.Concept
{
    // Basic Remote Control
    //  Sony Remote Control
    //  Samsung Remote Control
    //  Advanced Remote Control
    //    Sony Advanced Remote Control
    //    Samsung Advanced Remote Control
    // Movie Remote Control

    // 2 types of Remote Control -> 2 Classes for implementation and so On
    internal class RemoteControl
    {
        protected readonly IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}

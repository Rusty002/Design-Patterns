namespace Bridge.Concept
{
    internal class AdvancedRemoteControl : RemoteControl
    {
        private readonly IDevice _device;

        public AdvancedRemoteControl(IDevice device) : base(device)
        {
            _device = device;
        }

        public void SetChannel(int channelNumber)
        {
            _device.SetChannel(channelNumber);
        }
    }
}

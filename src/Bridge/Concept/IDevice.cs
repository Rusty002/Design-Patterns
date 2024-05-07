namespace Bridge.Concept
{
    internal interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channelNumber);
    }
}

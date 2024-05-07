namespace Bridge.Concept
{
    internal class SonyTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn On a Sony TV");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn Off a Sony TV");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Sony Take to channel: " + channelNumber);
        }
    }
}

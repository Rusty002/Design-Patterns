namespace Bridge.Concept
{
    internal class SamsungTV : IDevice
    {

        public void TurnOn()
        {
            Console.WriteLine("Turn On a Samsung TV");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn Off a Samsung TV");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Take to channel On a Samsung TV " + channelNumber);
        }
    }
}

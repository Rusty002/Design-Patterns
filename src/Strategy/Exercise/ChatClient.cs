namespace Strategy.Exercise
{
    public class ChatClient
    {
        //private Encryption EncryptionAlgorithm;

        //public ChatClient(Encryption encryptionAlgorithm)
        //{
        //    EncryptionAlgorithm = encryptionAlgorithm;
        //}

        public void Send(string message, Encryption encryptionAlgorithm)
        {
            encryptionAlgorithm.EncryptMessage(message);
            Console.WriteLine("Sending the encrypted message");
        }
    }
}

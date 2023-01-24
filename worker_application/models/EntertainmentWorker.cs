namespace WorkerApplication.Models
{
    internal class EntertainmentWorker : Worker
    {
        // Instantiate 'Entertainment Worker'
        public EntertainmentWorker()
        {
            // Create a new UUID and use Substring to make a short UUID
            uuid = Guid.NewGuid().ToString();
            shortUuid = uuid[..8];
        }

        // Override default "Run()" procedure with specific changes
        public override void Run()
        {
            Console.Write(" -- streaming netflix");
        }
    }
}

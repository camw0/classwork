namespace WorkerApplication.Models
{
    internal class CleanupWorker : Worker
    {
        // Instantiate 'Cleanup Worker'
        public CleanupWorker()
        {
            // Create a new UUID and use Substring to make a short UUID
            uuid = Guid.NewGuid().ToString();
            shortUuid = uuid[..8];
        }

        // Override default "Run()" procedure with specific changes
        public override void Run()
        {
            Console.Write(" -- removing waste");
        }
    }
}

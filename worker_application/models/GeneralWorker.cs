namespace WorkerApplication.Models
{
    internal class GeneralWorker : Worker
    {
        // Instantiate 'General Worker'
        public GeneralWorker()
        {
            // Create a new UUID and use Substring to make a short UUID
            uuid = Guid.NewGuid().ToString();
            shortUuid = uuid[..8];
        }

        // Override default "Run()" procedure with specific changes
        public override void Run()
        {
            Console.Write(" -- awaiting instructions");
        }
    }
}

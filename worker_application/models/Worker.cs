namespace WorkerApplication.Models
{
    internal abstract class Worker
    {
        // Define variables for uuid and shortUuid
        protected string uuid = "";
        protected string shortUuid = "";

        // This method is overriden by subclasses
        public abstract void Run();

        // Method to retrieve UUID from object
        public string GetUuid()
        {
            return uuid;
        }

        // Method to retrieve short UUID from object
        public string GetShortUuid()
        {
            return shortUuid;
        }
    }
}

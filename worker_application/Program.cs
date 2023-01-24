// We must manually import the models as they are in a different namespace
using WorkerApplication.Models;

namespace WorkerApplication
{
    public class Program
    {
        // Run 'Main' program entrypoint
        public static void Main()
        {
            // Create a new 'pool' of 'workers' that extend to the subclasses
            // e.g. CleanupWorker, HealthWorker
            Worker[] pool = new Worker[8];

            // While this isn't clean, I am too lazy to figure out a better way
            // of doing this. Maybe a for loop and the 'FizzBuzz' strategy?
            pool[0] = new CleanupWorker();
            pool[1] = new HealthWorker();
            pool[2] = new EntertainmentWorker();
            pool[3] = new GeneralWorker();
            pool[4] = new GeneralWorker();
            pool[5] = new GeneralWorker();
            pool[6] = new HealthWorker();
            pool[7] = new CleanupWorker();

            // Let the user know that the worker pool has been configured
            Console.WriteLine($"pool size is {pool.Length}, initializing workers\n");

            // Loop through the pool of workers one-by-one and run the procedures
            foreach (Worker worker in pool.Cast<Worker>())
            {
                // Grab shortUuid and name, and display them in the console
                Console.Write($"{worker.GetShortUuid()} ({worker.GetType().Name}) -- worker started");

                // Run the individually set 'Run()' procedure per-child class.
                // If one does not exist in a child class, nothing will happen.
                worker.Run();

                // Finally, let the user know the worker has done its job.
                // While this could be a procedure in the child/main class(es),
                // it does not seem necessary to do as it can merely be done here.
                Console.WriteLine(" -- worker stopped");
            }

            // And we're done!
            return;
        }
    }
}

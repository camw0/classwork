public class Logger
{
    bool debug = false;

    /**
     * Logger constructor.
     */
    void Logger(bool isDebug)
    {
        debug = isDebug;

        this.Reset();
    }

    /**
     * Prints out a 'new' message to the terminal.
     */
    void New(ConsoleColor? type, string content)
    {
        this.Reset();
        this.Set(type);
        this.Write(content);

        return;
    }

    /**
     * Sets the console color to a specified color.
     */
    private void Set(ConsoleColor color)
    {
        Console.ForegroundColor = color;
        if (debug) Console.WriteLine($"[DEBUG] {new DateTime()} ->");
    }

    /**
     * Resets the console color to white (default).
     */
    private void Reset(bool clear = false) 
    {
        if (clear) Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
    }
}
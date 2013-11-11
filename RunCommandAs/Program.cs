using CommandLine;

namespace RunCommandAs
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            if (!Parser.Default.ParseArguments(args, options)) return;
            
            var runAs = new RunCommandAs(options);
            runAs.Run();
        }
    }
}

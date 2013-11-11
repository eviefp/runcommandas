using CommandLine;

namespace RunCommandAs
{
    class Options
    {
        [Option('u', "user", Required = true, HelpText = "Username to run as.")]
        public string Username { get; set; }

        [Option('d', "domain", Required = false, HelpText = "Domain for the user.")]
        public string Domain { get; set;  }

        [Option('p', "pass", Required = true, HelpText = "Password for the selected user.")]
        public string Password { get; set; }

        [Option('c', "command", Required = true, HelpText = "Command to run (use parathesis).")]
        public string Command { get; set; }
    }
}
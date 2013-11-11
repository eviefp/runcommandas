using System.Diagnostics;
using System.Linq;
using System.Security;

namespace RunCommandAs
{
    class RunCommandAs
    {
        private readonly ProcessStartInfo _processInfo;

        public RunCommandAs(Options options)
        {
            var secureString = new SecureString();
            options.Password.ToList().ForEach(secureString.AppendChar);

            _processInfo = new ProcessStartInfo
            {
                FileName = options.Command,
                UserName = options.Username,
                Domain = options.Domain,
                Password = secureString,
                WorkingDirectory = options.WorkingDirectory
            };
        }

        public bool Run()
        {
            var process = Process.Start(_processInfo);

            process.Start();

            process.WaitForExit();
            return process.ExitCode == 0;
        }
    }
}
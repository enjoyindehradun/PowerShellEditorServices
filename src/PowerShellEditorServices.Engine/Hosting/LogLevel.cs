using Microsoft.Extensions.Logging;

namespace Microsoft.PowerShell.EditorServices.Engine
{
    public enum PsesLogLevel
    {
        Diagnostic,
        Verbose,
        Normal,
        Warning,
        Error,
    }

    internal static class PsesLogLevelExtensions
    {
        public static LogLevel ToExtensionsLogLevel(this PsesLogLevel logLevel)
        {
            switch (logLevel)
            {
                case PsesLogLevel.Diagnostic:
                    return LogLevel.Trace;

                case PsesLogLevel.Verbose:
                    return LogLevel.Debug;

                case PsesLogLevel.Normal:
                    return LogLevel.Information;

                case PsesLogLevel.Warning:
                    return LogLevel.Warning;

                case PsesLogLevel.Error:
                    return LogLevel.Error;

                default:
                    return LogLevel.Information;
            }
        }
    }
}

using mcbc.Debugging;

namespace mcbc
{
    public class mcbcConsts
    {
        public const string LocalizationSourceName = "mcbc";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "03c9e75b29e0497cb2e259ad34f477a8";
    }
}

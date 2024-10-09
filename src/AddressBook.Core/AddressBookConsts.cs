using AddressBook.Debugging;

namespace AddressBook
{
    public class AddressBookConsts
    {
        public const string LocalizationSourceName = "AddressBook";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a188eb270583420dbcf3107899a6dd26";
    }
}

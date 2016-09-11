namespace PclLocalizer.ResMan
{
    public static class PclResMan
    {
        /// <summary>
        /// Language
        /// </summary>
        public static string Lang { get; private set; }

        /// <summary>
        /// Default language
        /// </summary>
        public static string Default { get; private set; }
        
        /// <summary>
        /// Set language
        /// </summary>
        /// <param name="language"></param>
        public static void SetLanguage(string language)
        {
            Lang = language;
        }

        /// <summary>
        /// Set default language 
        /// if not set the default is the first
        /// </summary>
        /// <param name="language"></param>
        public static void SetDefault(string language)
        {
            Default = language;
        }
    }
}

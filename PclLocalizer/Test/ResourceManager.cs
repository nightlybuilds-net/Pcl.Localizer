namespace Test
{
    public static class ResourceManager
    {
        public static string Lang { get; private set; }
        public static string Default { get; private set; }

        public static void SetLanguage(string language)
        {
            Lang = language;
        }

        public static void SetDefault(string language)
        {
            Default = language;
        }
    }
}

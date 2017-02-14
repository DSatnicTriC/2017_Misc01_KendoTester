namespace DanielWebApp02.StaticHelpers
{
    public static class HtmlHelpers
    {
        public static bool UsingDebugConfiguration()
        {
            #if DEBUG
                return true;
            #else
                return false;
            #endif
        }
    }
}
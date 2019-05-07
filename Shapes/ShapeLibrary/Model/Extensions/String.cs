namespace ShapeLibrary.Model.Extensions
{
    public static class String
    {
        public static string GetLastString(this string value, char delimiter)
        {
            var a = value.Split(delimiter);
            if (a.Length < 1)
                return value;

            return a[a.Length-1];
        }
        
    }
}

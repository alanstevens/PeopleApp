namespace PeopleApp.Shared
{
  public static class ExtensionMethods
  {
    public static bool IsBlank(this string value) => string.IsNullOrWhiteSpace(value);

    public static bool IsNull(this object value) => ReferenceEquals(value, null);
  }
} 

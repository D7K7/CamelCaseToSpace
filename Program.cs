using System.Text.RegularExpressions;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    return Regex.Replace(str, "(\\B[A-Z])", " $1");
  }
}

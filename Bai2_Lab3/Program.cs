

public class Program
{
    public static void Main()
    {
        
        string username = "myUsername";
        string password = "myPassword";
        DateTime time = DateTime.Now;

        
        string savedData;
        using (StringWriter sw = new StringWriter())
        {
            sw.WriteLine(username);
            sw.WriteLine(password);
            sw.WriteLine(time);
            savedData = sw.ToString();
        }

        
        using (StringReader sr = new StringReader(savedData))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}

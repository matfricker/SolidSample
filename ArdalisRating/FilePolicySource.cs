using System.IO;

public class FilePolicySource
{
    public string GetPolicySource()
    {
        return File.ReadAllText("policy.json");
    }
}
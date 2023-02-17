namespace Namespace1.Controller;

public interface IMember
{
    public string Name { get; set; }

    public string Description { get; set; }
    public string Type { get; set; }
    public bool IsStatic { get; set; }
    public bool IsPublic { get; set; }
        
    public bool IsPrivate { get; set; }
    public bool IsProtected { get; set; }

}
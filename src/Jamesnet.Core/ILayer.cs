namespace Jamesnet.Core;

public interface ILayer
{
    object Content { get; set; }
    string LayerName { get; set; }
    bool IsRegistered { get; set; }
}

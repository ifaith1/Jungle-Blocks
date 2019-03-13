/// <summary>
/// Interface for elements the player can interact with by pressing the interact button
/// </summary>
// no public or private next to void because it already has been determineda s a public interface
public interface IInteractive
{
    string DisplayText { get; }
    void InteractWith();
}

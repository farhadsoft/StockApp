namespace StockApp.Data;

public class WebApiOptions
{
    public string Domain { get; init; } = null!;
    public string Path { get; init; } = null!;
    public int Port { get; init; }
    public int SecurePort { get; init; }

    public WebApiOptions() { }
}

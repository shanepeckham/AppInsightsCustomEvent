public class CustomEvent
{
    public string EventName { get; set; }
    public metrics Metrics { get; set; }
    public properties Properties { get; set; }

public class properties
{
    public string CorrelationId { get; set; }
    public string Description { get; set; }
    public string Host { get; set; }
    public string LogType { get; set; }
    public string RunName { get; set; }
}

public class metrics
{
    public int Metrics { get; set; }
}

}

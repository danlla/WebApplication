using Prometheus;

public static class Counters
{
    public static readonly Counter TestCounter = Metrics.CreateCounter("test_counter", "This us test counter. Call /inc_counter to increment it");
}

namespace Serilog.Sinks.OpenTelemetry.Sdk;

internal class OpenTelemetrySdkSink : ILogEventSink
{
    void ILogEventSink.Emit(LogEvent logEvent)
    {
        throw new NotImplementedException();
    }
}

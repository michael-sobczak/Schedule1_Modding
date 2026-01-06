public interface IAnalyticsStandardEventComponent : IServiceComponent // TypeDefIndex: 17810
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName);
}

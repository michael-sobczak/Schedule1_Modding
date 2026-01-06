public interface IMetrics // TypeDefIndex: 17795
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendGaugeMetric(string name, double value = 0, IDictionary<string, string> tags);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendHistogramMetric(string name, double time, IDictionary<string, string> tags);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendSumMetric(string name, double value = 1, IDictionary<string, string> tags);
}

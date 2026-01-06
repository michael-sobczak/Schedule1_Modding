public interface IQosResults : IServiceComponent // TypeDefIndex: 17783
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<IList<QosResult>> GetSortedQosResultsAsync(string service, IList<string> regions);
}

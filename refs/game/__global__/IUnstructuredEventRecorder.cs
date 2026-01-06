internal interface IUnstructuredEventRecorder // TypeDefIndex: 17898
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CustomData(string eventName, IDictionary<string, object> eventParams, Nullable<int> eventVersion, bool isStandardEvent, string callingMethodIdentifier);
}

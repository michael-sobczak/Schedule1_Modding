public interface IOnRequestProcessing // TypeDefIndex: 10683
{
	// Methods

	[NotNull]
	[ItemNotNull]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests);
}

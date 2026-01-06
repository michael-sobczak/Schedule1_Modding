public class CGModuleInputSlot : CGModuleSlot // TypeDefIndex: 10642
{
	// Properties
	public InputSlotInfo InputInfo { get; }

	// Methods

	// RVA: 0x4F3450 Offset: 0x4F1E50 VA: 0x1804F3450
	public InputSlotInfo get_InputInfo() { }

	// RVA: 0x4F2DB0 Offset: 0x4F17B0 VA: 0x1804F2DB0 Slot: 7
	protected override void LoadLinkedSlots() { }

	// RVA: 0x4F2D60 Offset: 0x4F1760 VA: 0x1804F2D60 Slot: 4
	public override void LinkTo(CGModuleSlot outputSlot) { }

	// RVA: 0x4F3300 Offset: 0x4F1D00 VA: 0x1804F3300 Slot: 5
	public override void UnlinkFrom(CGModuleSlot outputSlot) { }

	// RVA: 0x4F3220 Offset: 0x4F1C20 VA: 0x1804F3220
	public CGModuleOutputSlot SourceSlot(int index = 0) { }

	// RVA: 0x4F2AA0 Offset: 0x4F14A0 VA: 0x1804F2AA0
	public bool CanLinkTo(CGModuleOutputSlot source) { }

	// RVA: 0x4F2930 Offset: 0x4F1330 VA: 0x1804F2930
	public static bool AreInputAndOutputSlotsCompatible(InputSlotInfo inputSlotInfo, bool inputSlotModuleIsOnRequest, OutputSlotInfo outputSlotInfo, bool outputSlotModuleIsOnRequest) { }

	// RVA: 0x4F3170 Offset: 0x4F1B70 VA: 0x1804F3170
	private CGModule SourceModule(int index) { }

	[CanBeNull]
	// RVA: -1 Offset: -1
	public T GetData<T>(CGDataRequestParameter[] requests) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5C100 Offset: 0xE5AB00 VA: 0x180E5C100
	|-CGModuleInputSlot.GetData<object>
	*/

	[CanBeNull]
	// RVA: -1 Offset: -1
	public T GetData<T>(out bool isDataDisposable, CGDataRequestParameter[] requests) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5C220 Offset: 0xE5AC20 VA: 0x180E5C220
	|-CGModuleInputSlot.GetData<object>
	*/

	[NotNull]
	// RVA: -1 Offset: -1
	public List<T> GetAllData<T>(CGDataRequestParameter[] requests) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B660 Offset: 0xE5A060 VA: 0x180E5B660
	|-CGModuleInputSlot.GetAllData<object>
	*/

	[NotNull]
	// RVA: -1 Offset: -1
	public List<T> GetAllData<T>(out bool isDataDisposable, CGDataRequestParameter[] requests) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B6C0 Offset: 0xE5A0C0 VA: 0x180E5B6C0
	|-CGModuleInputSlot.GetAllData<object>
	*/

	[NotNull]
	// RVA: -1 Offset: -1
	private CGData[] GetData<T>(int slotIndex, out bool isDataDisposable, CGDataRequestParameter[] requests) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B950 Offset: 0xE5A350 VA: 0x180E5B950
	|-CGModuleInputSlot.GetData<object>
	*/

	[NotNull]
	// RVA: -1 Offset: -1
	private static CGData[] CloneData<T>(CGData[] source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B570 Offset: 0xE59F70 VA: 0x180E5B570
	|-CGModuleInputSlot.CloneData<object>
	*/

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

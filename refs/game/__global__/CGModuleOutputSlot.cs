public class CGModuleOutputSlot : CGModuleSlot // TypeDefIndex: 10646
{
	// Fields
	[ItemNotNull]
	[NotNull]
	private CGData[] data; // 0x40
	[CanBeNull]
	public CGDataRequestParameter[] LastRequestParameters; // 0x48

	// Properties
	[NotNull]
	[ItemNotNull]
	public CGData[] Data { get; set; }
	[CanBeNull]
	public OutputSlotInfo OutputInfo { get; }
	[Obsolete("Use Data instead")]
	[UsedImplicitly]
	public bool HasData { get; }

	// Methods

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public CGData[] get_Data() { }

	[Obsolete("Use ClearData, SetDataToElement or SetDataToCollection instead.")]
	[UsedImplicitly]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Data(CGData[] value) { }

	// RVA: 0x4F47B0 Offset: 0x4F31B0 VA: 0x1804F47B0
	public OutputSlotInfo get_OutputInfo() { }

	// RVA: 0x4F4090 Offset: 0x4F2A90 VA: 0x1804F4090 Slot: 7
	protected override void LoadLinkedSlots() { }

	// RVA: 0x4F4040 Offset: 0x4F2A40 VA: 0x1804F4040 Slot: 4
	public override void LinkTo(CGModuleSlot inputSlot) { }

	// RVA: 0x4F45F0 Offset: 0x4F2FF0 VA: 0x1804F45F0 Slot: 5
	public override void UnlinkFrom(CGModuleSlot inputSlot) { }

	// RVA: 0x4F3FF0 Offset: 0x4F29F0 VA: 0x1804F3FF0
	public void ClearData() { }

	// RVA: -1 Offset: -1
	public void SetDataToElement<T>(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5C4B0 Offset: 0xE5AEB0 VA: 0x180E5C4B0
	|-CGModuleOutputSlot.SetDataToElement<object>
	*/

	// RVA: -1 Offset: -1
	public void SetDataToCollection<T>(T[] elements) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5C440 Offset: 0xE5AE40 VA: 0x180E5C440
	|-CGModuleOutputSlot.SetDataToCollection<object>
	*/

	// RVA: 0x4F4790 Offset: 0x4F3190 VA: 0x1804F4790
	public bool get_HasData() { }

	[UsedImplicitly]
	[Obsolete("Use SetDataToElement or SetDataToCollection instead.")]
	// RVA: -1 Offset: -1
	public void SetData<T>(List<T> newData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5C5B0 Offset: 0xE5AFB0 VA: 0x180E5C5B0
	|-CGModuleOutputSlot.SetData<object>
	*/

	[UsedImplicitly]
	[Obsolete("Use SetDataToElement or SetDataToCollection instead.")]
	// RVA: 0x4F4450 Offset: 0x4F2E50 VA: 0x1804F4450
	public void SetData(CGData[] newData) { }

	[CanBeNull]
	[UsedImplicitly]
	[Obsolete("Use Data instead")]
	// RVA: -1 Offset: -1
	public T GetData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5C370 Offset: 0xE5AD70 VA: 0x180E5C370
	|-CGModuleOutputSlot.GetData<object>
	*/

	[Obsolete("Use Data instead")]
	[CanBeNull]
	[UsedImplicitly]
	// RVA: -1 Offset: -1
	public T[] GetAllData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5C320 Offset: 0xE5AD20 VA: 0x180E5C320
	|-CGModuleOutputSlot.GetAllData<object>
	*/

	// RVA: 0x4F3CC0 Offset: 0x4F26C0 VA: 0x1804F3CC0
	private void AssignNewData(CGData[] newData) { }

	// RVA: 0x4F4740 Offset: 0x4F3140 VA: 0x1804F4740
	public void .ctor() { }
}

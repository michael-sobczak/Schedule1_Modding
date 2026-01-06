public class ModifierTRSShape : TRSModuleBase, IOnRequestProcessing, IPathProvider // TypeDefIndex: 10743
{
	// Fields
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGShape) }, Name = "Shape A", ModifiesData = True)]
	public CGModuleInputSlot InShape; // 0xE8
	[HideInInspector]
	[OutputSlotInfo(typeof(CGShape))]
	public CGModuleOutputSlot OutShape; // 0xF0

	// Properties
	public bool PathIsClosed { get; }

	// Methods

	// RVA: 0x539580 Offset: 0x537F80 VA: 0x180539580 Slot: 19
	public bool get_PathIsClosed() { }

	// RVA: 0x539390 Offset: 0x537D90 VA: 0x180539390 Slot: 18
	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests) { }

	// RVA: 0x5394D0 Offset: 0x537ED0 VA: 0x1805394D0
	public void .ctor() { }
}

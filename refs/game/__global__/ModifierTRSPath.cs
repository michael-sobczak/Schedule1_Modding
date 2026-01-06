public class ModifierTRSPath : TRSModuleBase, IOnRequestProcessing, IPathProvider // TypeDefIndex: 10742
{
	// Fields
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGPath) }, Name = "Path A", ModifiesData = True)]
	public CGModuleInputSlot InPath; // 0xE8
	[OutputSlotInfo(typeof(CGPath))]
	[HideInInspector]
	public CGModuleOutputSlot OutPath; // 0xF0

	// Properties
	public bool PathIsClosed { get; }

	// Methods

	// RVA: 0x539300 Offset: 0x537D00 VA: 0x180539300 Slot: 19
	public bool get_PathIsClosed() { }

	// RVA: 0x539010 Offset: 0x537A10 VA: 0x180539010 Slot: 18
	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests) { }

	// RVA: 0x539250 Offset: 0x537C50 VA: 0x180539250
	public void .ctor() { }
}

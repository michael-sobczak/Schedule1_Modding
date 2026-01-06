public class ModifierTRSMesh : TRSModuleBase // TypeDefIndex: 10741
{
	// Fields
	[InputSlotInfo(new[] { typeof(CGVMesh) }, Array = True, ModifiesData = True)]
	[HideInInspector]
	public CGModuleInputSlot InVMesh; // 0xE8
	[HideInInspector]
	[OutputSlotInfo(typeof(CGVMesh), Array = True)]
	public CGModuleOutputSlot OutVMesh; // 0xF0

	// Methods

	// RVA: 0x538D90 Offset: 0x537790 VA: 0x180538D90 Slot: 14
	public override void Refresh() { }

	// RVA: 0x538F60 Offset: 0x537960 VA: 0x180538F60
	public void .ctor() { }
}

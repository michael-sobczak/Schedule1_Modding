public class DebugVMesh : CGModule // TypeDefIndex: 10720
{
	// Fields
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGVMesh) }, Name = "VMesh")]
	public CGModuleInputSlot InData; // 0xC0
	[Tab("General")]
	public bool ShowVertices; // 0xC8
	public bool ShowVertexID; // 0xC9
	public bool ShowUV; // 0xCA

	// Methods

	// RVA: 0x523BD0 Offset: 0x5225D0 VA: 0x180523BD0 Slot: 13
	public override void Reset() { }

	// RVA: 0x523C00 Offset: 0x522600 VA: 0x180523C00
	public void .ctor() { }
}

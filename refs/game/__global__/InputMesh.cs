public class InputMesh : CGModule, IExternalInput // TypeDefIndex: 10729
{
	// Fields
	[HideInInspector]
	[OutputSlotInfo(typeof(CGVMesh), Array = True)]
	public CGModuleOutputSlot OutVMesh; // 0xC0
	[SerializeField]
	[ArrayEx]
	private List<CGMeshProperties> m_Meshes; // 0xC8

	// Properties
	public List<CGMeshProperties> Meshes { get; }
	public bool SupportsIPE { get; }

	// Methods

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public List<CGMeshProperties> get_Meshes() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	public bool get_SupportsIPE() { }

	// RVA: 0x532C50 Offset: 0x531650 VA: 0x180532C50 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x532FC0 Offset: 0x5319C0 VA: 0x180532FC0 Slot: 13
	public override void Reset() { }

	// RVA: 0x532D50 Offset: 0x531750 VA: 0x180532D50 Slot: 14
	public override void Refresh() { }

	// RVA: 0x532BE0 Offset: 0x5315E0 VA: 0x180532BE0 Slot: 17
	public override void OnTemplateCreated() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x533130 Offset: 0x531B30 VA: 0x180533130
	private void WarnAboutInvalidInputs() { }

	// RVA: 0x5334B0 Offset: 0x531EB0 VA: 0x1805334B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x533030 Offset: 0x531A30 VA: 0x180533030
	private void <WarnAboutInvalidInputs>b__10_3(Mesh m) { }
}

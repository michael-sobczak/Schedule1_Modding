public class BuildVolumeCaps : CGModule // TypeDefIndex: 10705
{
	// Fields
	[InputSlotInfo(new[] { typeof(CGVolume) })]
	[HideInInspector]
	public CGModuleInputSlot InVolume; // 0xC0
	[InputSlotInfo(new[] { typeof(CGVolume) }, Optional = True, Array = True)]
	[HideInInspector]
	public CGModuleInputSlot InVolumeHoles; // 0xC8
	[OutputSlotInfo(typeof(CGVMesh), Array = True)]
	[HideInInspector]
	public CGModuleOutputSlot OutVMesh; // 0xD0
	[SerializeField]
	[Tab("General")]
	private CGYesNoAuto m_StartCap; // 0xD8
	[SerializeField]
	private CGYesNoAuto m_EndCap; // 0xDC
	[SerializeField]
	[FormerlySerializedAs("m_ReverseNormals")]
	private bool m_ReverseTriOrder; // 0xE0
	[SerializeField]
	private bool m_GenerateUV; // 0xE1
	[SerializeField]
	private bool m_GenerateUV2; // 0xE2
	[SerializeField]
	[Inline]
	[Tab("Start Cap")]
	private CGMaterialSettings m_StartMaterialSettings; // 0xE8
	[SerializeField]
	[Label("Material", "")]
	private Material m_StartMaterial; // 0xF0
	[SerializeField]
	[Tab("End Cap")]
	private bool m_CloneStartCap; // 0xF8
	[AsGroup(null, Invisible = True)]
	[SerializeField]
	[GroupCondition("m_CloneStartCap", False, False)]
	private CGMaterialSettings m_EndMaterialSettings; // 0x100
	[SerializeField]
	[FieldCondition("m_CloneStartCap", False, False, 0, null, 1)]
	[Group("Default/End Cap")]
	[Label("Material", "")]
	private Material m_EndMaterial; // 0x108

	// Properties
	public bool GenerateUV { get; set; }
	public bool GenerateUV2 { get; set; }
	public bool ReverseTriOrder { get; set; }
	public CGYesNoAuto StartCap { get; set; }
	public Material StartMaterial { get; set; }
	public CGMaterialSettings StartMaterialSettings { get; }
	public CGYesNoAuto EndCap { get; set; }
	public bool CloneStartCap { get; set; }
	public CGMaterialSettings EndMaterialSettings { get; }
	public Material EndMaterial { get; set; }

	// Methods

	// RVA: 0x516280 Offset: 0x514C80 VA: 0x180516280
	public bool get_GenerateUV() { }

	// RVA: 0x5165A0 Offset: 0x514FA0 VA: 0x1805165A0
	public void set_GenerateUV(bool value) { }

	// RVA: 0x516270 Offset: 0x514C70 VA: 0x180516270
	public bool get_GenerateUV2() { }

	// RVA: 0x516580 Offset: 0x514F80 VA: 0x180516580
	public void set_GenerateUV2(bool value) { }

	// RVA: 0x510890 Offset: 0x50F290 VA: 0x180510890
	public bool get_ReverseTriOrder() { }

	// RVA: 0x510C40 Offset: 0x50F640 VA: 0x180510C40
	public void set_ReverseTriOrder(bool value) { }

	// RVA: 0x516290 Offset: 0x514C90 VA: 0x180516290
	public CGYesNoAuto get_StartCap() { }

	// RVA: 0x5165C0 Offset: 0x514FC0 VA: 0x1805165C0
	public void set_StartCap(CGYesNoAuto value) { }

	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public Material get_StartMaterial() { }

	// RVA: 0x5165E0 Offset: 0x514FE0 VA: 0x1805165E0
	public void set_StartMaterial(Material value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public CGMaterialSettings get_StartMaterialSettings() { }

	// RVA: 0x510B10 Offset: 0x50F510 VA: 0x180510B10
	public CGYesNoAuto get_EndCap() { }

	// RVA: 0x5164C0 Offset: 0x514EC0 VA: 0x1805164C0
	public void set_EndCap(CGYesNoAuto value) { }

	// RVA: 0x516240 Offset: 0x514C40 VA: 0x180516240
	public bool get_CloneStartCap() { }

	// RVA: 0x5164A0 Offset: 0x514EA0 VA: 0x1805164A0
	public void set_CloneStartCap(bool value) { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public CGMaterialSettings get_EndMaterialSettings() { }

	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public Material get_EndMaterial() { }

	// RVA: 0x5164E0 Offset: 0x514EE0 VA: 0x1805164E0
	public void set_EndMaterial(Material value) { }

	// RVA: 0x513A50 Offset: 0x512450 VA: 0x180513A50 Slot: 11
	protected override void Awake() { }

	// RVA: 0x515460 Offset: 0x513E60 VA: 0x180515460 Slot: 13
	public override void Reset() { }

	// RVA: 0x513B20 Offset: 0x512520 VA: 0x180513B20 Slot: 14
	public override void Refresh() { }

	// RVA: 0x515F00 Offset: 0x514900 VA: 0x180515F00
	private static Matrix4x4 getMatrix(CGVolume vol, int index, bool inverse) { }

	// RVA: 0x515E90 Offset: 0x514890 VA: 0x180515E90
	private static void flipTris(SubArray<int> indices, int start, int end) { }

	// RVA: 0x515750 Offset: 0x514150 VA: 0x180515750
	private static SubArray<Vector3> applyMatrix(SubArray<Vector3> vt, Matrix4x4 matrix, out Bounds bounds) { }

	// RVA: 0x5162B0 Offset: 0x514CB0 VA: 0x1805162B0
	private static ContourVertex[] make2DSegment(CGVolume vol, int segmentIndex) { }

	// RVA: 0x515B60 Offset: 0x514560 VA: 0x180515B60
	private static void applyUV(SubArray<Vector3> vts, SubArray<Vector2> uvArray, int index, int count, CGMaterialSettings mat, Bounds bounds) { }

	// RVA: 0x515A60 Offset: 0x514460 VA: 0x180515A60
	private static void applyUV2(SubArray<Vector3> vertice, SubArray<Vector2> uv2Array, int index, int count, Bounds bounds) { }

	// RVA: 0x5155E0 Offset: 0x513FE0 VA: 0x1805155E0
	public void .ctor() { }
}

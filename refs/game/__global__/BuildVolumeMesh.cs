public class BuildVolumeMesh : CGModule // TypeDefIndex: 10706
{
	// Fields
	private const float DefaultUnscalingOrigin = 0.5;
	private const int DefaultSplitLength = 100;
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGVolume) })]
	public CGModuleInputSlot InVolume; // 0xC0
	[HideInInspector]
	[OutputSlotInfo(typeof(CGVMesh), Array = True)]
	public CGModuleOutputSlot OutVMesh; // 0xC8
	[Tab("General")]
	[FieldAction("CBAddMaterial", 7)]
	[SerializeField]
	[FormerlySerializedAs("m_ReverseNormals")]
	private bool m_ReverseTriOrder; // 0xD0
	[SerializeField]
	[Section("Default/General/UV", True, False, 100)]
	private bool m_GenerateUV; // 0xD1
	[FieldCondition("m_GenerateUV", True, False, 0, null, 1)]
	[Tooltip("When set to true, and if the input Shape Extrusion module is set to apply scaling, the U coordinate of the generated mesh will be modified to compensate that scaling.
Only the X component of the scaling is taken into consideration.
The unscaling works best on volumes with flat shapes.")]
	[SerializeField]
	private bool unscaleU; // 0xD2
	[FieldCondition("unscaleU", True, False, 0, "m_GenerateUV", True, False)]
	[Tooltip("When unscaling the U coordinate, this field defines what is the scaling origin.
0.5 gives usually the best results, but you might need to set it to a different value, usually between 0 and 1")]
	[SerializeField]
	private float unscalingOrigin; // 0xD4
	[SerializeField]
	private bool m_GenerateUV2; // 0xD8
	[Tooltip("Split the mesh into submeshes")]
	[Section("Default/General/Split", True, False, 100)]
	[SerializeField]
	private bool m_Split; // 0xD9
	[FieldCondition("m_Split", True, False, 0, null, 1)]
	[Positive(MinValue = 1)]
	[SerializeField]
	private float m_SplitLength; // 0xDC
	[Tooltip("Is ignored when Split or Generate UV2 is false.
If enabled, UV2s of a split mesh will be computed as in Curvy versions prior to 8.0.0, which had a bug: all the split submeshes used the full range of UV2 coordinates, instead of keeping the same UV2s from the unsplit mesh.")]
	[Group("Default/General/Backward Compatibility", Expanded = False)]
	[SerializeField]
	[FieldCondition("IsSplitUV2Togglable", True, False, 2, null, 1)]
	private bool splitUV2; // 0xE0
	[HideInInspector]
	[SerializeField]
	private List<CGMaterialSettingsEx> m_MaterialSettings; // 0xE8
	[SerializeField]
	[HideInInspector]
	private Material[] m_Material; // 0xF0

	// Properties
	public bool GenerateUV { get; set; }
	public bool GenerateUV2 { get; set; }
	public bool UnscaleU { get; set; }
	public float UnscalingOrigin { get; set; }
	public bool ReverseTriOrder { get; set; }
	public bool Split { get; set; }
	public float SplitLength { get; set; }
	public bool SplitUV2 { get; set; }
	[Obsolete("Use MaterialSettings (with the correct number of Ts) instead")]
	public List<CGMaterialSettingsEx> MaterialSetttings { get; }
	public List<CGMaterialSettingsEx> MaterialSettings { get; }
	public int MaterialCount { get; }
	private bool IsSplitUV2Togglable { get; }

	// Methods

	// RVA: 0x518770 Offset: 0x517170 VA: 0x180518770
	public bool get_GenerateUV() { }

	// RVA: 0x518A10 Offset: 0x517410 VA: 0x180518A10
	public void set_GenerateUV(bool value) { }

	// RVA: 0x4B5E70 Offset: 0x4B4870 VA: 0x1804B5E70
	public bool get_GenerateUV2() { }

	// RVA: 0x5189F0 Offset: 0x5173F0 VA: 0x1805189F0
	public void set_GenerateUV2(bool value) { }

	// RVA: 0x518810 Offset: 0x517210 VA: 0x180518810
	public bool get_UnscaleU() { }

	// RVA: 0x518AA0 Offset: 0x5174A0 VA: 0x180518AA0
	public void set_UnscaleU(bool value) { }

	// RVA: 0x510B20 Offset: 0x50F520 VA: 0x180510B20
	public float get_UnscalingOrigin() { }

	// RVA: 0x518AC0 Offset: 0x5174C0 VA: 0x180518AC0
	public void set_UnscalingOrigin(float value) { }

	// RVA: 0x5187E0 Offset: 0x5171E0 VA: 0x1805187E0
	public bool get_ReverseTriOrder() { }

	// RVA: 0x518A30 Offset: 0x517430 VA: 0x180518A30
	public void set_ReverseTriOrder(bool value) { }

	// RVA: 0x518800 Offset: 0x517200 VA: 0x180518800
	public bool get_Split() { }

	// RVA: 0x518A80 Offset: 0x517480 VA: 0x180518A80
	public void set_Split(bool value) { }

	// RVA: 0x5187F0 Offset: 0x5171F0 VA: 0x1805187F0
	public float get_SplitLength() { }

	// RVA: 0x518A50 Offset: 0x517450 VA: 0x180518A50
	public void set_SplitLength(float value) { }

	// RVA: 0x510890 Offset: 0x50F290 VA: 0x180510890
	public bool get_SplitUV2() { }

	// RVA: 0x510C40 Offset: 0x50F640 VA: 0x180510C40
	public void set_SplitUV2(bool value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public List<CGMaterialSettingsEx> get_MaterialSetttings() { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public List<CGMaterialSettingsEx> get_MaterialSettings() { }

	// RVA: 0x5187A0 Offset: 0x5171A0 VA: 0x1805187A0
	public int get_MaterialCount() { }

	// RVA: 0x5167E0 Offset: 0x5151E0 VA: 0x1805167E0 Slot: 11
	protected override void Awake() { }

	// RVA: 0x517040 Offset: 0x515A40 VA: 0x180517040 Slot: 13
	public override void Reset() { }

	// RVA: 0x5169E0 Offset: 0x5153E0 VA: 0x1805169E0 Slot: 14
	public override void Refresh() { }

	// RVA: 0x516680 Offset: 0x515080 VA: 0x180516680
	public int AddMaterial() { }

	// RVA: 0x516F90 Offset: 0x515990 VA: 0x180516F90
	public void RemoveMaterial(int index) { }

	// RVA: 0x517300 Offset: 0x515D00 VA: 0x180517300
	public void SetMaterial(int index, Material mat) { }

	// RVA: 0x516980 Offset: 0x515380 VA: 0x180516980
	public Material GetMaterial(int index) { }

	// RVA: 0x5175B0 Offset: 0x515FB0 VA: 0x1805175B0
	private void build(CGVMesh vmesh, CGVolume vol, IntRegion subset, List<SamplePointsMaterialGroupCollection> materialIdGroups) { }

	// RVA: 0x518820 Offset: 0x517220 VA: 0x180518820
	private static void prepareSubMeshes(CGVMesh vmesh, List<SamplePointsMaterialGroupCollection> groupsBySubMeshes, int extrusions, ref Material[] materials) { }

	// RVA: 0x517EE0 Offset: 0x5168E0 VA: 0x180517EE0
	private void createMaterialGroupUV(CGVMesh vmesh, CGVolume volume, SamplePointsMaterialGroup materialGroup, int matIndex, float aspectCorrectionV, float aspectCorrectionU, int sample, int baseVertex) { }

	// RVA: 0x517DC0 Offset: 0x5167C0 VA: 0x180517DC0
	private void createMaterialGroupUV2(CGVMesh vmesh, CGVolume volume, SamplePointsMaterialGroup materialGroup, int sample, int baseVertex) { }

	// RVA: 0x518150 Offset: 0x516B50 VA: 0x180518150
	private static void createPatchTriangles(int[] triangles, ref int triIdx, int curVTIndex, int patchSize, int crossSize, bool reverse) { }

	// RVA: 0x518270 Offset: 0x516C70 VA: 0x180518270
	private List<SamplePointsMaterialGroupCollection> getMaterialIDGroups(CGVolume volume) { }

	// RVA: 0x518AF0 Offset: 0x5174F0 VA: 0x180518AF0
	private bool validateMaterialIndex(int index) { }

	// RVA: 0x518780 Offset: 0x517180 VA: 0x180518780
	private bool get_IsSplitUV2Togglable() { }

	// RVA: 0x517460 Offset: 0x515E60 VA: 0x180517460
	public void .ctor() { }
}

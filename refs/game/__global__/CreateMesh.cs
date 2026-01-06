public class CreateMesh : ResourceExportingModule, ISerializationCallbackReceiver // TypeDefIndex: 10717
{
	// Fields
	private const string DefaultTag = "Untagged";
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGVMesh) }, Array = True, Name = "VMesh")]
	public CGModuleInputSlot InVMeshArray; // 0xC0
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGSpots) }, Array = True, Name = "Spots", Optional = True)]
	public CGModuleInputSlot InSpots; // 0xC8
	[SerializeField]
	[CGResourceCollectionManager("Mesh", ShowCount = True)]
	private CGMeshResourceCollection m_MeshResources; // 0xD0
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	[Tooltip("Merge meshes")]
	[Tab("General")]
	[SerializeField]
	private bool m_Combine; // 0xD8
	[Tooltip("Warning: this operation is Editor only (not available in builds) and CPU intensive.
When combining multiple meshes, the UV2s are by default kept as is. Use this option to recompute them by uwrapping the combined mesh.")]
	[SerializeField]
	[FieldCondition("m_Combine", True, False, 0, null, 1, Action = 0)]
	private bool unwrapUV2; // 0xD9
	[Tooltip("When Combine is true, combine only meshes sharing the same index
Is used only if Spots are provided")]
	[SerializeField]
	private bool m_GroupMeshes; // 0xDA
	[SerializeField]
	[Tooltip("If true, the generated mesh will have normals")]
	private bool includeNormals; // 0xDB
	[Tooltip("If true, the generated mesh will have tangents")]
	[SerializeField]
	private bool includeTangents; // 0xDC
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	[HideInInspector]
	[SerializeField]
	private CGYesNoAuto m_AddNormals; // 0xE0
	[HideInInspector]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	[SerializeField]
	private CGYesNoAuto m_AddTangents; // 0xE4
	[HideInInspector]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	[SerializeField]
	private bool m_AddUV2; // 0xE8
	[SerializeField]
	[Tooltip("If enabled, meshes will have the Static flag set, and will not be generated/updated in Play Mode")]
	[FieldCondition("CanModifyStaticFlag", True, False, 0, null, 1, Action = 2)]
	private bool m_MakeStatic; // 0xE9
	[Tooltip("The Layer of the created game object")]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	[SerializeField]
	[Layer("", "")]
	private int m_Layer; // 0xEC
	[Tag("", "")]
	[SerializeField]
	[Tooltip("The Tag of the created game object")]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	private string m_Tag; // 0xF0
	[Tab("Renderer")]
	[SerializeField]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	private bool m_RendererEnabled; // 0xF8
	[SerializeField]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	private ShadowCastingMode m_CastShadows; // 0xFC
	[SerializeField]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	private bool m_ReceiveShadows; // 0x100
	[SerializeField]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	private LightProbeUsage m_LightProbeUsage; // 0x104
	[HideInInspector]
	[SerializeField]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	private bool m_UseLightProbes; // 0x108
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	[SerializeField]
	private ReflectionProbeUsage m_ReflectionProbes; // 0x10C
	[SerializeField]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	private Transform m_AnchorOverride; // 0x110
	[Tab("Collider")]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	[SerializeField]
	private CGColliderEnum m_Collider; // 0x118
	[FieldCondition("m_Collider", 1, False, 0, null, 1)]
	[SerializeField]
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	private bool m_Convex; // 0x11C
	[SerializeField]
	[FieldCondition("EnableIsTrigger", True, False, 0, null, 1, Action = 2)]
	private bool m_IsTrigger; // 0x11D
	[FieldCondition("CanUpdate", True, False, 0, null, 1, Action = 2)]
	[FieldCondition("m_Collider", 1, False, 0, null, 1)]
	[Tooltip("Options used to enable or disable certain features in Collider mesh cooking. See Unity's MeshCollider.cookingOptions for more details")]
	[EnumFlag("", "")]
	[SerializeField]
	private MeshColliderCookingOptions m_CookingOptions; // 0x120
	[SerializeField]
	[Label("Auto Update", "")]
	private bool m_AutoUpdateColliders; // 0x124
	[SerializeField]
	private PhysicMaterial m_Material; // 0x128
	[CompilerGenerated]
	private int <VertexCount>k__BackingField; // 0x130
	private readonly CGSpotComparer cgSpotComparer; // 0x138

	// Properties
	public bool Combine { get; set; }
	public bool UnwrapUV2 { get; set; }
	public bool GroupMeshes { get; set; }
	public bool IncludeNormals { get; set; }
	public bool IncludeTangents { get; set; }
	[UsedImplicitly]
	[Obsolete("Use IncludeNormals instead")]
	public CGYesNoAuto AddNormals { get; set; }
	[Obsolete("Use IncludeTangents instead")]
	[UsedImplicitly]
	public CGYesNoAuto AddTangents { get; set; }
	[UsedImplicitly]
	[Obsolete("UV2 is now always added")]
	public bool AddUV2 { get; set; }
	public int Layer { get; set; }
	public string Tag { get; set; }
	public bool MakeStatic { get; set; }
	public bool RendererEnabled { get; set; }
	public ShadowCastingMode CastShadows { get; set; }
	public bool ReceiveShadows { get; set; }
	public bool UseLightProbes { get; set; }
	public LightProbeUsage LightProbeUsage { get; set; }
	public ReflectionProbeUsage ReflectionProbes { get; set; }
	public Transform AnchorOverride { get; set; }
	public CGColliderEnum Collider { get; set; }
	public bool AutoUpdateColliders { get; set; }
	public bool Convex { get; set; }
	public bool IsTrigger { get; set; }
	public MeshColliderCookingOptions CookingOptions { get; set; }
	public PhysicMaterial Material { get; set; }
	[Obsolete("Member is set to become editor only. Contact support if you need it outside of Editor")]
	public CGMeshResourceCollection Meshes { get; }
	[Obsolete("Member is set to become editor only. Contact support if you need it outside of Editor")]
	public int MeshCount { get; }
	[Obsolete("Member is set to become editor only. Contact support if you need it outside of Editor")]
	public int VertexCount { get; set; }
	private bool CanGroupMeshes { get; }
	private bool CanModifyStaticFlag { get; }
	private bool CanUpdate { get; }
	private bool EnableIsTrigger { get; }

	// Methods

	// RVA: 0x4B5E70 Offset: 0x4B4870 VA: 0x1804B5E70
	public bool get_Combine() { }

	// RVA: 0x5189F0 Offset: 0x5173F0 VA: 0x1805189F0
	public void set_Combine(bool value) { }

	// RVA: 0x518800 Offset: 0x517200 VA: 0x180518800
	public bool get_UnwrapUV2() { }

	// RVA: 0x5237D0 Offset: 0x5221D0 VA: 0x1805237D0
	public void set_UnwrapUV2(bool value) { }

	// RVA: 0x523350 Offset: 0x521D50 VA: 0x180523350
	public bool get_GroupMeshes() { }

	// RVA: 0x5235A0 Offset: 0x521FA0 VA: 0x1805235A0
	public void set_GroupMeshes(bool value) { }

	// RVA: 0x523360 Offset: 0x521D60 VA: 0x180523360
	public bool get_IncludeNormals() { }

	// RVA: 0x5235C0 Offset: 0x521FC0 VA: 0x1805235C0
	public void set_IncludeNormals(bool value) { }

	// RVA: 0x523370 Offset: 0x521D70 VA: 0x180523370
	public bool get_IncludeTangents() { }

	// RVA: 0x5235E0 Offset: 0x521FE0 VA: 0x1805235E0
	public void set_IncludeTangents(bool value) { }

	// RVA: 0x505860 Offset: 0x504260 VA: 0x180505860
	public CGYesNoAuto get_AddNormals() { }

	// RVA: 0x523420 Offset: 0x521E20 VA: 0x180523420
	public void set_AddNormals(CGYesNoAuto value) { }

	// RVA: 0x5231E0 Offset: 0x521BE0 VA: 0x1805231E0
	public CGYesNoAuto get_AddTangents() { }

	// RVA: 0x523440 Offset: 0x521E40 VA: 0x180523440
	public void set_AddTangents(CGYesNoAuto value) { }

	// RVA: 0x510B30 Offset: 0x50F530 VA: 0x180510B30
	public bool get_AddUV2() { }

	// RVA: 0x510D30 Offset: 0x50F730 VA: 0x180510D30
	public void set_AddUV2(bool value) { }

	// RVA: 0x523390 Offset: 0x521D90 VA: 0x180523390
	public int get_Layer() { }

	// RVA: 0x523620 Offset: 0x522020 VA: 0x180523620
	public void set_Layer(int value) { }

	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public string get_Tag() { }

	// RVA: 0x523770 Offset: 0x522170 VA: 0x180523770
	public void set_Tag(string value) { }

	// RVA: 0x5233B0 Offset: 0x521DB0 VA: 0x1805233B0
	public bool get_MakeStatic() { }

	// RVA: 0x523670 Offset: 0x522070 VA: 0x180523670
	public void set_MakeStatic(bool value) { }

	// RVA: 0x516240 Offset: 0x514C40 VA: 0x180516240
	public bool get_RendererEnabled() { }

	// RVA: 0x5164A0 Offset: 0x514EA0 VA: 0x1805164A0
	public void set_RendererEnabled(bool value) { }

	// RVA: 0x5232A0 Offset: 0x521CA0 VA: 0x1805232A0
	public ShadowCastingMode get_CastShadows() { }

	// RVA: 0x523520 Offset: 0x521F20 VA: 0x180523520
	public void set_CastShadows(ShadowCastingMode value) { }

	// RVA: 0x523400 Offset: 0x521E00 VA: 0x180523400
	public bool get_ReceiveShadows() { }

	// RVA: 0x523730 Offset: 0x522130 VA: 0x180523730
	public void set_ReceiveShadows(bool value) { }

	// RVA: 0x4F17A0 Offset: 0x4F01A0 VA: 0x1804F17A0
	public bool get_UseLightProbes() { }

	// RVA: 0x523840 Offset: 0x522240 VA: 0x180523840
	public void set_UseLightProbes(bool value) { }

	// RVA: 0x5233A0 Offset: 0x521DA0 VA: 0x1805233A0
	public LightProbeUsage get_LightProbeUsage() { }

	// RVA: 0x523650 Offset: 0x522050 VA: 0x180523650
	public void set_LightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x51DA20 Offset: 0x51C420 VA: 0x18051DA20
	public ReflectionProbeUsage get_ReflectionProbes() { }

	// RVA: 0x523750 Offset: 0x522150 VA: 0x180523750
	public void set_ReflectionProbes(ReflectionProbeUsage value) { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public Transform get_AnchorOverride() { }

	// RVA: 0x523460 Offset: 0x521E60 VA: 0x180523460
	public void set_AnchorOverride(Transform value) { }

	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0
	public CGColliderEnum get_Collider() { }

	// RVA: 0x523540 Offset: 0x521F40 VA: 0x180523540
	public void set_Collider(CGColliderEnum value) { }

	// RVA: 0x523200 Offset: 0x521C00 VA: 0x180523200
	public bool get_AutoUpdateColliders() { }

	// RVA: 0x523500 Offset: 0x521F00 VA: 0x180523500
	public void set_AutoUpdateColliders(bool value) { }

	// RVA: 0x5232C0 Offset: 0x521CC0 VA: 0x1805232C0
	public bool get_Convex() { }

	// RVA: 0x523560 Offset: 0x521F60 VA: 0x180523560
	public void set_Convex(bool value) { }

	// RVA: 0x523380 Offset: 0x521D80 VA: 0x180523380
	public bool get_IsTrigger() { }

	// RVA: 0x523600 Offset: 0x522000 VA: 0x180523600
	public void set_IsTrigger(bool value) { }

	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	public MeshColliderCookingOptions get_CookingOptions() { }

	// RVA: 0x523580 Offset: 0x521F80 VA: 0x180523580
	public void set_CookingOptions(MeshColliderCookingOptions value) { }

	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public PhysicMaterial get_Material() { }

	// RVA: 0x523690 Offset: 0x522090 VA: 0x180523690
	public void set_Material(PhysicMaterial value) { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public CGMeshResourceCollection get_Meshes() { }

	// RVA: 0x5233D0 Offset: 0x521DD0 VA: 0x1805233D0
	public int get_MeshCount() { }

	[CompilerGenerated]
	// RVA: 0x523410 Offset: 0x521E10 VA: 0x180523410
	public int get_VertexCount() { }

	[CompilerGenerated]
	// RVA: 0x523860 Offset: 0x522260 VA: 0x180523860
	private void set_VertexCount(int value) { }

	// RVA: 0x523210 Offset: 0x521C10 VA: 0x180523210
	private bool get_CanGroupMeshes() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private bool get_CanModifyStaticFlag() { }

	// RVA: 0x523240 Offset: 0x521C40 VA: 0x180523240
	private bool get_CanUpdate() { }

	// RVA: 0x5232E0 Offset: 0x521CE0 VA: 0x1805232E0
	private bool get_EnableIsTrigger() { }

	// RVA: 0x5218E0 Offset: 0x5202E0 VA: 0x1805218E0 Slot: 13
	public override void Reset() { }

	// RVA: 0x523010 Offset: 0x521A10 VA: 0x180523010
	public void .ctor() { }

	// RVA: 0x520840 Offset: 0x51F240 VA: 0x180520840 Slot: 15
	public override bool DeleteAllOutputManagedResources() { }

	[Obsolete("Use DeleteAllOutputManagedResources instead")]
	[UsedImplicitly]
	// RVA: 0x4DD630 Offset: 0x4DC030 VA: 0x1804DD630
	public void Clear() { }

	// RVA: 0x520F00 Offset: 0x51F900 VA: 0x180520F00 Slot: 14
	public override void Refresh() { }

	// RVA: 0x522430 Offset: 0x520E30 VA: 0x180522430
	public void UpdateColliders() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 19
	public void OnBeforeSerialize() { }

	// RVA: 0x520E60 Offset: 0x51F860 VA: 0x180520E60 Slot: 20
	public void OnAfterDeserialize() { }

	// RVA: 0x51FD30 Offset: 0x51E730 VA: 0x18051FD30
	private void CreateMeshes(List<CGVMesh> vMeshes, bool combine, List<CGMeshResource> createdMeshes) { }

	// RVA: 0x51FE50 Offset: 0x51E850 VA: 0x18051FE50
	private void CreateSpotMeshes(List<CGVMesh> vMeshes, SubArray<CGSpot> spots, bool combine, bool spotsIsACopy, List<CGMeshResource> createdMeshes) { }

	// RVA: 0x522C70 Offset: 0x521670 VA: 0x180522C70
	private CGMeshResource WriteVMeshToMesh(CGVMesh vmesh, List<CGMeshResource> cgMeshResources) { }

	// RVA: 0x520C70 Offset: 0x51F670 VA: 0x180520C70
	private CGMeshResource GetNewMesh(int currentMeshCount) { }

	// RVA: 0x521EE0 Offset: 0x5208E0 VA: 0x180521EE0
	private static Nullable<SubArray<CGSpot>> ToOneDimensionalArray(List<CGSpots> spotsList, out bool arrayIsCopy) { }

	[Conditional("CURVY_SANITY_CHECKS_PRIVATE")]
	// RVA: 0x522980 Offset: 0x521380 VA: 0x180522980
	private void ValidateMesh(Mesh mesh) { }

	// RVA: 0x5218D0 Offset: 0x5202D0 VA: 0x1805218D0 Slot: 5
	protected override void ResetOnEnable() { }

	// RVA: 0x521E40 Offset: 0x520840 VA: 0x180521E40
	public void SaveToAsset() { }

	// RVA: 0x521E90 Offset: 0x520890 VA: 0x180521E90
	public void SaveToSceneAndAsset() { }

	// RVA: 0x521CE0 Offset: 0x5206E0 VA: 0x180521CE0 Slot: 18
	protected override GameObject SaveResourceToScene(Component managedResource, Transform newParent) { }
}

public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 14846
{
	// Fields
	[SerializeField]
	internal int _SortingLayer; // 0x6D8
	[SerializeField]
	internal int _SortingLayerID; // 0x6DC
	[SerializeField]
	internal int _SortingOrder; // 0x6E0
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x6E8
	[SerializeField]
	private bool m_hasFontAssetChanged; // 0x6F0
	private float m_previousLossyScaleY; // 0x6F4
	[SerializeField]
	private Renderer m_renderer; // 0x6F8
	private MeshFilter m_meshFilter; // 0x700
	private bool m_isFirstAllocation; // 0x708
	private int m_max_characters; // 0x70C
	private int m_max_numberOfLines; // 0x710
	private TMP_SubMesh[] m_subTextObjects; // 0x718
	[SerializeField]
	private MaskingTypes m_maskType; // 0x720
	private Matrix4x4 m_EnvMapMatrix; // 0x724
	private Vector3[] m_RectTransformCorners; // 0x768
	private bool m_isRegisteredForEvents; // 0x770
	private static ProfilerMarker k_GenerateTextMarker; // 0x0
	private static ProfilerMarker k_SetArraySizesMarker; // 0x8
	private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
	private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
	private static ProfilerMarker k_CharacterLookupMarker; // 0x20
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
	private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
	private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
	private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
	private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
	private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
	private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
	private static ProfilerMarker k_SavePageInfoMarker; // 0x80
	private static ProfilerMarker k_SaveTextExtentMarker; // 0x88
	private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x90
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x98
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0xA0

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x2BD4FB0 Offset: 0x2BD39B0 VA: 0x182BD4FB0
	public int get_sortingLayerID() { }

	// RVA: 0x2BD52D0 Offset: 0x2BD3CD0 VA: 0x182BD52D0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2BD5040 Offset: 0x2BD3A40 VA: 0x182BD5040
	public int get_sortingOrder() { }

	// RVA: 0x2BD5490 Offset: 0x2BD3E90 VA: 0x182BD5490
	public void set_sortingOrder(int value) { }

	// RVA: 0x2BCC8F0 Offset: 0x2BCB2F0 VA: 0x182BCC8F0 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x2BD5230 Offset: 0x2BD3C30 VA: 0x182BD5230 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public TextContainer get_textContainer() { }

	// RVA: 0x2BD50D0 Offset: 0x2BD3AD0 VA: 0x182BD50D0
	public Transform get_transform() { }

	// RVA: 0x2BD4F10 Offset: 0x2BD3910 VA: 0x182BD4F10
	public Renderer get_renderer() { }

	// RVA: 0x2BD4E40 Offset: 0x2BD3840 VA: 0x182BD4E40 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x2BD4D10 Offset: 0x2BD3710 VA: 0x182BD4D10
	public MeshFilter get_meshFilter() { }

	// RVA: 0x2BD4D00 Offset: 0x2BD3700 VA: 0x182BD4D00
	public MaskingTypes get_maskType() { }

	// RVA: 0x2BD52C0 Offset: 0x2BD3CC0 VA: 0x182BD52C0
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x2BD2830 Offset: 0x2BD1230 VA: 0x182BD2830
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x2BD2A80 Offset: 0x2BD1480 VA: 0x182BD2A80
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x2BD3650 Offset: 0x2BD2050 VA: 0x182BD3650 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x2BD25C0 Offset: 0x2BD0FC0 VA: 0x182BD25C0 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1C043E0 Offset: 0x1C02DE0 VA: 0x181C043E0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x2BC6AD0 Offset: 0x2BC54D0 VA: 0x182BC6AD0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x2BCF010 Offset: 0x2BCDA10 VA: 0x182BCF010 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x2BD3B30 Offset: 0x2BD2530 VA: 0x182BD3B30 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x2BD3C70 Offset: 0x2BD2670 VA: 0x182BD3C70 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x2BCD6C0 Offset: 0x2BCC0C0 VA: 0x182BCD6C0 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x2BCE030 Offset: 0x2BCCA30 VA: 0x182BCE030 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x2BCCF00 Offset: 0x2BCB900 VA: 0x182BCCF00 Slot: 130
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGenerated]
	// RVA: 0x2BD4C40 Offset: 0x2BD3640 VA: 0x182BD4C40 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x2BD5170 Offset: 0x2BD3B70 VA: 0x182BD5170 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x2BD39D0 Offset: 0x2BD23D0 VA: 0x182BD39D0 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x2BD4250 Offset: 0x2BD2C50 VA: 0x182BD4250 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x2BD4440 Offset: 0x2BD2E40 VA: 0x182BD4440 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x2BCB230 Offset: 0x2BC9C30 VA: 0x182BCB230
	public void UpdateFontAsset() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x2BCCB90 Offset: 0x2BCB590 VA: 0x182BCCB90 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2BCE960 Offset: 0x2BCD360 VA: 0x182BCE960 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2BCE8C0 Offset: 0x2BCD2C0 VA: 0x182BCE8C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2BCE7C0 Offset: 0x2BCD1C0 VA: 0x182BCE7C0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2BCE180 Offset: 0x2BCCB80 VA: 0x182BCE180 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x2BD36F0 Offset: 0x2BD20F0 VA: 0x182BD36F0
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x2BD28D0 Offset: 0x2BD12D0 VA: 0x182BD28D0
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x2BD27A0 Offset: 0x2BD11A0 VA: 0x182BD27A0
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x2BD2690 Offset: 0x2BD1090 VA: 0x182BD2690
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x2BCD580 Offset: 0x2BCBF80 VA: 0x182BCD580
	private void EnableMasking() { }

	// RVA: 0x2BCD330 Offset: 0x2BCBD30 VA: 0x182BCD330
	private void DisableMasking() { }

	// RVA: 0x2BD39F0 Offset: 0x2BD23F0 VA: 0x182BD39F0
	private void UpdateMask() { }

	// RVA: 0x2BCD9D0 Offset: 0x2BCC3D0 VA: 0x182BCD9D0 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x2BCDB10 Offset: 0x2BCC510 VA: 0x182BCDB10 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x2BCA700 Offset: 0x2BC9100 VA: 0x182BCA700 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x2BCDD60 Offset: 0x2BCC760 VA: 0x182BCDD60 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x2BD31F0 Offset: 0x2BD1BF0 VA: 0x182BD31F0 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x2BD2F60 Offset: 0x2BD1960 VA: 0x182BD2F60 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x2BD2430 Offset: 0x2BD0E30 VA: 0x182BD2430 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x2BD2DD0 Offset: 0x2BD17D0 VA: 0x182BD2DD0 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x2BCD140 Offset: 0x2BCBB40 VA: 0x182BCD140
	private void CreateMaterialInstance() { }

	// RVA: 0x2BD31B0 Offset: 0x2BD1BB0 VA: 0x182BD31B0 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x2BD20E0 Offset: 0x2BD0AE0 VA: 0x182BD20E0 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x2BD30F0 Offset: 0x2BD1AF0 VA: 0x182BD30F0
	private void SetPerspectiveCorrection() { }

	// RVA: 0x2BCF3A0 Offset: 0x2BCDDA0 VA: 0x182BCF3A0 Slot: 114
	internal override int SetArraySizes(TMP_Text.TextProcessingElement[] textProcessingArray) { }

	// RVA: 0x2BCCFF0 Offset: 0x2BCB9F0 VA: 0x182BCCFF0 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x2BCE890 Offset: 0x2BCD290 VA: 0x182BCE890 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2BCEFD0 Offset: 0x2BCD9D0 VA: 0x182BCEFD0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2BCEE20 Offset: 0x2BCD820 VA: 0x182BCEE20 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2BCE0B0 Offset: 0x2BCCAB0 VA: 0x182BCE0B0 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x2BCEA60 Offset: 0x2BCD460 VA: 0x182BCEA60
	private void OnPreRenderObject() { }

	// RVA: 0x2BA8270 Offset: 0x2BA6C70 VA: 0x182BA8270 Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x2BCDF80 Offset: 0x2BCC980 VA: 0x182BCDF80 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x2BD2B90 Offset: 0x2BD1590 VA: 0x182BD2B90
	private void SetMeshFilters(bool state) { }

	// RVA: 0x2BCF0F0 Offset: 0x2BCDAF0 VA: 0x182BCF0F0 Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x2BCF230 Offset: 0x2BCDC30 VA: 0x182BCF230
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x2BCD220 Offset: 0x2BCBC20 VA: 0x182BCD220 Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x2BD3FB0 Offset: 0x2BD29B0 VA: 0x182BD3FB0
	internal void UpdateSubMeshSortingLayerID(int id) { }

	// RVA: 0x2BD4100 Offset: 0x2BD2B00 VA: 0x182BD4100
	internal void UpdateSubMeshSortingOrder(int order) { }

	// RVA: 0x2BCD6E0 Offset: 0x2BCC0E0 VA: 0x182BCD6E0 Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x2BD3DA0 Offset: 0x2BD27A0 VA: 0x182BD3DA0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x2BD4B70 Offset: 0x2BD3570 VA: 0x182BD4B70
	public void .ctor() { }

	// RVA: 0x2BD4670 Offset: 0x2BD3070 VA: 0x182BD4670
	private static void .cctor() { }
}

public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 14849
{
	// Fields
	private bool m_isRebuildingLayout; // 0x6D8
	private Coroutine m_DelayedGraphicRebuild; // 0x6E0
	private Coroutine m_DelayedMaterialRebuild; // 0x6E8
	private bool m_ShouldUpdateCulling; // 0x6F0
	private Rect m_ClipRect; // 0x6F4
	private bool m_ValidRect; // 0x704
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x708
	[SerializeField]
	private bool m_hasFontAssetChanged; // 0x710
	protected TMP_SubMeshUI[] m_subTextObjects; // 0x718
	private float m_previousLossyScaleY; // 0x720
	private Vector3[] m_RectTransformCorners; // 0x728
	private CanvasRenderer m_canvasRenderer; // 0x730
	private Canvas m_canvas; // 0x738
	private float m_CanvasScaleFactor; // 0x740
	private bool m_isFirstAllocation; // 0x744
	private int m_max_characters; // 0x748
	[SerializeField]
	private Material m_baseMaterial; // 0x750
	private bool m_isScrollRegionSet; // 0x758
	[SerializeField]
	private Vector4 m_maskOffset; // 0x75C
	private Matrix4x4 m_EnvMapMatrix; // 0x76C
	private bool m_isRegisteredForEvents; // 0x7AC
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
	public override Material materialForRendering { get; }
	public override bool autoSizeTextContainer { get; set; }
	public override Mesh mesh { get; }
	public CanvasRenderer canvasRenderer { get; }
	public Vector4 maskOffset { get; set; }

	// Methods

	// RVA: 0x2BCC9B0 Offset: 0x2BCB3B0 VA: 0x182BCC9B0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x2BCC8F0 Offset: 0x2BCB2F0 VA: 0x182BCC8F0 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x2BCCAD0 Offset: 0x2BCB4D0 VA: 0x182BCCAD0 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x2BCC900 Offset: 0x2BCB300 VA: 0x182BCC900
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x2BCAC90 Offset: 0x2BC9690 VA: 0x182BCAC90 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x2BC9F40 Offset: 0x2BC8940 VA: 0x182BC9F40 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x2BCA020 Offset: 0x2BC8A20 VA: 0x182BCA020 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x2BC6AD0 Offset: 0x2BC54D0 VA: 0x182BC6AD0 Slot: 26
	public override void SetAllDirty() { }

	[IteratorStateMachine(typeof(TextMeshProUGUI.<DelayedGraphicRebuild>d__18))]
	// RVA: 0x2BC3E00 Offset: 0x2BC2800 VA: 0x182BC3E00
	private IEnumerator DelayedGraphicRebuild() { }

	[IteratorStateMachine(typeof(TextMeshProUGUI.<DelayedMaterialRebuild>d__19))]
	// RVA: 0x2BC3E70 Offset: 0x2BC2870 VA: 0x182BC3E70
	private IEnumerator DelayedMaterialRebuild() { }

	// RVA: 0x2BC68A0 Offset: 0x2BC52A0 VA: 0x182BC68A0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x2BCBCA0 Offset: 0x2BCA6A0 VA: 0x182BCBCA0
	private void UpdateSubObjectPivot() { }

	// RVA: 0x2BC4D50 Offset: 0x2BC3750 VA: 0x182BC4D50 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x2BCB760 Offset: 0x2BCA160 VA: 0x182BCB760 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x2BCC9A0 Offset: 0x2BCB3A0 VA: 0x182BCC9A0
	public Vector4 get_maskOffset() { }

	// RVA: 0x2BCCB60 Offset: 0x2BCB560 VA: 0x182BCCB60
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0x2BC6980 Offset: 0x2BC5380 VA: 0x182BC6980 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x2BC3BD0 Offset: 0x2BC25D0 VA: 0x182BC3BD0 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x2BCAD60 Offset: 0x2BC9760 VA: 0x182BCAD60 Slot: 102
	internal override void UpdateCulling() { }

	// RVA: 0x2BCB8C0 Offset: 0x2BCA2C0 VA: 0x182BCB8C0 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x2BC5360 Offset: 0x2BC3D60 VA: 0x182BC5360 Slot: 112
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x2BC5280 Offset: 0x2BC3C80 VA: 0x182BC5280 Slot: 113
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x2BC4230 Offset: 0x2BC2C30 VA: 0x182BC4230 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x2BC5180 Offset: 0x2BC3B80 VA: 0x182BC5180 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x2BC3950 Offset: 0x2BC2350 VA: 0x182BC3950 Slot: 129
	public override void ClearMesh() { }

	[CompilerGenerated]
	// RVA: 0x2BCC830 Offset: 0x2BCB230 VA: 0x182BCC830 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x2BCCA10 Offset: 0x2BCB410 VA: 0x182BCCA10 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x2BCB250 Offset: 0x2BC9C50 VA: 0x182BCB250 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x2BCBDA0 Offset: 0x2BCA7A0 VA: 0x182BCBDA0 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x2BCBFE0 Offset: 0x2BCA9E0 VA: 0x182BCBFE0 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x2BCB230 Offset: 0x2BC9C30 VA: 0x182BCB230
	public void UpdateFontAsset() { }

	// RVA: 0x2BC3620 Offset: 0x2BC2020 VA: 0x182BC3620 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2BC5FD0 Offset: 0x2BC49D0 VA: 0x182BC5FD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2BC5E40 Offset: 0x2BC4840 VA: 0x182BC5E40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2BC5C90 Offset: 0x2BC4690 VA: 0x182BC5C90 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2BC5550 Offset: 0x2BC3F50 VA: 0x182BC5550 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x2BC4550 Offset: 0x2BC2F50 VA: 0x182BC4550
	private Canvas GetCanvas() { }

	// RVA: 0x2BCAF50 Offset: 0x2BC9950 VA: 0x182BCAF50
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x2BC3FF0 Offset: 0x2BC29F0 VA: 0x182BC3FF0
	private void EnableMasking() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void DisableMasking() { }

	// RVA: 0x2BCB2E0 Offset: 0x2BC9CE0 VA: 0x182BCB2E0
	private void UpdateMask() { }

	// RVA: 0x2BC4990 Offset: 0x2BC3390 VA: 0x182BC4990 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x2BC4B00 Offset: 0x2BC3500 VA: 0x182BC4B00 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x2BCA700 Offset: 0x2BC9100 VA: 0x182BCA700 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x2BC4EB0 Offset: 0x2BC38B0 VA: 0x182BC4EB0 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x2BCA760 Offset: 0x2BC9160 VA: 0x182BCA760 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x2BCA360 Offset: 0x2BC8D60 VA: 0x182BCA360 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x2BC9DA0 Offset: 0x2BC87A0 VA: 0x182BC9DA0 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x2BCA1C0 Offset: 0x2BC8BC0 VA: 0x182BCA1C0 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x2BCA650 Offset: 0x2BC9050 VA: 0x182BCA650 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x2BC9A00 Offset: 0x2BC8400 VA: 0x182BC9A00 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x2BCA590 Offset: 0x2BC8F90 VA: 0x182BCA590
	private void SetPerspectiveCorrection() { }

	// RVA: 0x2BCA100 Offset: 0x2BC8B00 VA: 0x182BCA100
	private void SetMeshArrays(int size) { }

	// RVA: 0x2BC6B20 Offset: 0x2BC5520 VA: 0x182BC6B20 Slot: 114
	internal override int SetArraySizes(TMP_Text.TextProcessingElement[] textProcessingArray) { }

	// RVA: 0x2BC3A80 Offset: 0x2BC2480 VA: 0x182BC3A80 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x2BC5E00 Offset: 0x2BC4800 VA: 0x182BC5E00 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2BC5B60 Offset: 0x2BC4560 VA: 0x182BC5B60 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x2BC6840 Offset: 0x2BC5240 VA: 0x182BC6840 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2BC6510 Offset: 0x2BC4F10 VA: 0x182BC6510 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2BC5480 Offset: 0x2BC3E80 VA: 0x182BC5480 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x2BC6250 Offset: 0x2BC4C50 VA: 0x182BC6250
	private void OnPreRenderCanvas() { }

	// RVA: 0x2BB4530 Offset: 0x2BB2F30 VA: 0x182BB4530 Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x2BC50D0 Offset: 0x2BC3AD0 VA: 0x182BC50D0 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x2BC6990 Offset: 0x2BC5390 VA: 0x182BC6990 Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x2BC3EE0 Offset: 0x2BC28E0 VA: 0x182BC3EE0 Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x2BC46A0 Offset: 0x2BC30A0 VA: 0x182BC46A0 Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x2BC42E0 Offset: 0x2BC2CE0 VA: 0x182BC42E0 Slot: 117
	internal override Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x2BCB9F0 Offset: 0x2BCA3F0 VA: 0x182BCB9F0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x2BCC760 Offset: 0x2BCB160 VA: 0x182BCC760
	public void .ctor() { }

	// RVA: 0x2BCC260 Offset: 0x2BCAC60 VA: 0x182BCC260
	private static void .cctor() { }
}

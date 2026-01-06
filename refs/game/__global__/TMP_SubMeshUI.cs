public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 14970
{
	// Fields
	[SerializeField]
	private TMP_FontAsset m_fontAsset; // 0xE0
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; // 0xE8
	[SerializeField]
	private Material m_material; // 0xF0
	[SerializeField]
	private Material m_sharedMaterial; // 0xF8
	private Material m_fallbackMaterial; // 0x100
	private Material m_fallbackSourceMaterial; // 0x108
	[SerializeField]
	private bool m_isDefaultMaterial; // 0x110
	[SerializeField]
	private float m_padding; // 0x114
	private Mesh m_mesh; // 0x118
	[SerializeField]
	private TextMeshProUGUI m_TextComponent; // 0x120
	private bool m_isRegisteredForEvents; // 0x128
	private bool m_materialDirty; // 0x129
	[SerializeField]
	private int m_materialReferenceIndex; // 0x12C
	private Transform m_RootCanvasTransform; // 0x130

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public override Texture mainTexture { get; }
	public override Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public override Material materialForRendering { get; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x4E8E60 Offset: 0x4E7860 VA: 0x1804E8E60
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x2C2D400 Offset: 0x2C2BE00 VA: 0x182C2D400 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x2C2D520 Offset: 0x2C2BF20 VA: 0x182C2D520 Slot: 32
	public override Material get_material() { }

	// RVA: 0x2C2D840 Offset: 0x2C2C240 VA: 0x182C2D840 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	public Material get_sharedMaterial() { }

	// RVA: 0x2C2D030 Offset: 0x2C2BA30 VA: 0x182C2D030
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public Material get_fallbackMaterial() { }

	// RVA: 0x2C2D6A0 Offset: 0x2C2C0A0 VA: 0x182C2D6A0
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x2C2D4C0 Offset: 0x2C2BEC0 VA: 0x182C2D4C0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x9876C0 Offset: 0x9860C0 VA: 0x1809876C0
	public bool get_isDefaultMaterial() { }

	// RVA: 0x9876E0 Offset: 0x9860E0 VA: 0x1809876E0
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x513360 Offset: 0x511D60 VA: 0x180513360
	public float get_padding() { }

	// RVA: 0x2C2D950 Offset: 0x2C2C350 VA: 0x182C2D950
	public void set_padding(float value) { }

	// RVA: 0x2C2D530 Offset: 0x2C2BF30 VA: 0x182C2D530
	public Mesh get_mesh() { }

	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	public void set_mesh(Mesh value) { }

	// RVA: 0x2C2D600 Offset: 0x2C2C000 VA: 0x182C2D600
	public TMP_Text get_textComponent() { }

	// RVA: 0x2C2C200 Offset: 0x2C2AC00 VA: 0x182C2C200
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0x2C2CE50 Offset: 0x2C2B850 VA: 0x182C2CE50 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2C2CD90 Offset: 0x2C2B790 VA: 0x182C2CD90 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2C2CBB0 Offset: 0x2C2B5B0 VA: 0x182C2CBB0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2C2CEC0 Offset: 0x2C2B8C0 VA: 0x182C2CEC0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2C2C840 Offset: 0x2C2B240 VA: 0x182C2C840 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x2C2CA30 Offset: 0x2C2B430 VA: 0x182C2CA30
	public float GetPaddingForMaterial() { }

	// RVA: 0x2C2C9A0 Offset: 0x2C2B3A0 VA: 0x182C2C9A0
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x2C2D370 Offset: 0x2C2BD70 VA: 0x182C2D370
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x2C2D090 Offset: 0x2C2BA90 VA: 0x182C2D090 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x2C2CF60 Offset: 0x2C2B960 VA: 0x182C2CF60 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x2C2CFB0 Offset: 0x2C2B9B0 VA: 0x182C2CFB0
	public void SetPivotDirty() { }

	// RVA: 0x2C2CAC0 Offset: 0x2C2B4C0 VA: 0x182C2CAC0
	private Transform GetRootCanvasTransform() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x2C2CF20 Offset: 0x2C2B920 VA: 0x182C2CF20 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1C043E0 Offset: 0x1C02DE0 VA: 0x181C043E0
	public void RefreshMaterial() { }

	// RVA: 0x2C2D150 Offset: 0x2C2BB50 VA: 0x182C2D150 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x2BC6980 Offset: 0x2BC5380 VA: 0x182BC6980 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	private Material GetMaterial() { }

	// RVA: 0x2C2C680 Offset: 0x2C2B080 VA: 0x182C2C680
	private Material GetMaterial(Material mat) { }

	// RVA: 0x2C2C5C0 Offset: 0x2C2AFC0 VA: 0x182C2C5C0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x2C2CB80 Offset: 0x2C2B580 VA: 0x182C2CB80
	private Material GetSharedMaterial() { }

	// RVA: 0x2C2D030 Offset: 0x2C2BA30 VA: 0x182C2D030
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x2C27550 Offset: 0x2C25F50 VA: 0x182C27550
	public void .ctor() { }
}

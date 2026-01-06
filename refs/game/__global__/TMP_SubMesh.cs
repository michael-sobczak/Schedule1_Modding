public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 14969
{
	// Fields
	[SerializeField]
	private TMP_FontAsset m_fontAsset; // 0x20
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; // 0x28
	[SerializeField]
	private Material m_material; // 0x30
	[SerializeField]
	private Material m_sharedMaterial; // 0x38
	private Material m_fallbackMaterial; // 0x40
	private Material m_fallbackSourceMaterial; // 0x48
	[SerializeField]
	private bool m_isDefaultMaterial; // 0x50
	[SerializeField]
	private float m_padding; // 0x54
	[SerializeField]
	private Renderer m_renderer; // 0x58
	private MeshFilter m_meshFilter; // 0x60
	private Mesh m_mesh; // 0x68
	[SerializeField]
	private TextMeshPro m_TextComponent; // 0x70
	private bool m_isRegisteredForEvents; // 0x78

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Renderer renderer { get; }
	public MeshFilter meshFilter { get; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x2C2E940 Offset: 0x2C2D340 VA: 0x182C2E940
	public Material get_material() { }

	// RVA: 0x2C2EDB0 Offset: 0x2C2D7B0 VA: 0x182C2EDB0
	public void set_material(Material value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Material get_sharedMaterial() { }

	// RVA: 0x2C2E5D0 Offset: 0x2C2CFD0 VA: 0x182C2E5D0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Material get_fallbackMaterial() { }

	// RVA: 0x2C2EC50 Offset: 0x2C2D650 VA: 0x182C2EC50
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_isDefaultMaterial() { }

	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_padding() { }

	// RVA: 0x66B050 Offset: 0x669A50 VA: 0x18066B050
	public void set_padding(float value) { }

	// RVA: 0x2C2EB30 Offset: 0x2C2D530 VA: 0x182C2EB30
	public Renderer get_renderer() { }

	// RVA: 0x2C2E950 Offset: 0x2C2D350 VA: 0x182C2E950
	public MeshFilter get_meshFilter() { }

	// RVA: 0x2C2EA70 Offset: 0x2C2D470 VA: 0x182C2EA70
	public Mesh get_mesh() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_mesh(Mesh value) { }

	// RVA: 0x2C2EBC0 Offset: 0x2C2D5C0 VA: 0x182C2EBC0
	public TMP_Text get_textComponent() { }

	// RVA: 0x2C2D960 Offset: 0x2C2C360 VA: 0x182C2D960
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0x2C2E320 Offset: 0x2C2CD20 VA: 0x182C2E320
	private void OnEnable() { }

	// RVA: 0x2C2E260 Offset: 0x2C2CC60 VA: 0x182C2E260
	private void OnDisable() { }

	// RVA: 0x2C2E110 Offset: 0x2C2CB10 VA: 0x182C2E110
	private void OnDestroy() { }

	// RVA: 0x2C2DDA0 Offset: 0x2C2C7A0 VA: 0x182C2DDA0
	public void DestroySelf() { }

	// RVA: 0x2C2DE00 Offset: 0x2C2C800 VA: 0x182C2DE00
	private Material GetMaterial(Material mat) { }

	// RVA: 0x2C2DCE0 Offset: 0x2C2C6E0 VA: 0x182C2DCE0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x2C2E070 Offset: 0x2C2CA70 VA: 0x182C2E070
	private Material GetSharedMaterial() { }

	// RVA: 0x2C2E5D0 Offset: 0x2C2CFD0 VA: 0x182C2E5D0
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x2C2DFE0 Offset: 0x2C2C9E0 VA: 0x182C2DFE0
	public float GetPaddingForMaterial() { }

	// RVA: 0x2C2E8C0 Offset: 0x2C2D2C0 VA: 0x182C2E8C0
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x2C2E610 Offset: 0x2C2D010 VA: 0x182C2E610
	public void SetVerticesDirty() { }

	// RVA: 0x2C2E5C0 Offset: 0x2C2CFC0 VA: 0x182C2E5C0
	public void SetMaterialDirty() { }

	// RVA: 0x2C2E6C0 Offset: 0x2C2D0C0 VA: 0x182C2E6C0
	protected void UpdateMaterial() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

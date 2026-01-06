public class OutlineTarget // TypeDefIndex: 10838
{
	// Fields
	public bool IsVisible; // 0x10
	[SerializeField]
	public ColorMask CutoutMask; // 0x14
	[SerializeField]
	private float edgeDilateAmount; // 0x18
	[SerializeField]
	private float frontEdgeDilateAmount; // 0x1C
	[SerializeField]
	private float backEdgeDilateAmount; // 0x20
	[SerializeField]
	[FormerlySerializedAs("Renderer")]
	public Renderer renderer; // 0x28
	[SerializeField]
	public int SubmeshIndex; // 0x30
	[SerializeField]
	public BoundsMode BoundsMode; // 0x34
	[SerializeField]
	public Bounds Bounds; // 0x38
	[Range(0, 1)]
	[SerializeField]
	public float CutoutThreshold; // 0x50
	[SerializeField]
	public CullMode CullMode; // 0x54
	[SerializeField]
	private string cutoutTextureName; // 0x58
	[SerializeField]
	public DilateRenderMode DilateRenderingMode; // 0x60
	[SerializeField]
	private int cutoutTextureIndex; // 0x64
	private Nullable<int> cutoutTextureId; // 0x68

	// Properties
	public Renderer Renderer { get; }
	public bool UsesCutout { get; }
	public int CutoutTextureIndex { get; set; }
	public int ShiftedSubmeshIndex { get; }
	public int CutoutTextureId { get; }
	public string CutoutTextureName { get; set; }
	public float EdgeDilateAmount { get; set; }
	public float FrontEdgeDilateAmount { get; set; }
	public float BackEdgeDilateAmount { get; set; }

	// Methods

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Renderer get_Renderer() { }

	// RVA: 0x54BD80 Offset: 0x54A780 VA: 0x18054BD80
	public bool get_UsesCutout() { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public int get_CutoutTextureIndex() { }

	// RVA: 0x54BDC0 Offset: 0x54A7C0 VA: 0x18054BDC0
	public void set_CutoutTextureIndex(int value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_ShiftedSubmeshIndex() { }

	// RVA: 0x54BCE0 Offset: 0x54A6E0 VA: 0x18054BCE0
	public int get_CutoutTextureId() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_CutoutTextureName() { }

	// RVA: 0x54BE40 Offset: 0x54A840 VA: 0x18054BE40
	public void set_CutoutTextureName(string value) { }

	// RVA: 0x54BD70 Offset: 0x54A770 VA: 0x18054BD70
	public float get_EdgeDilateAmount() { }

	// RVA: 0x54BE70 Offset: 0x54A870 VA: 0x18054BE70
	public void set_EdgeDilateAmount(float value) { }

	// RVA: 0x498A60 Offset: 0x497460 VA: 0x180498A60
	public float get_FrontEdgeDilateAmount() { }

	// RVA: 0x54BE90 Offset: 0x54A890 VA: 0x18054BE90
	public void set_FrontEdgeDilateAmount(float value) { }

	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_BackEdgeDilateAmount() { }

	// RVA: 0x54BDA0 Offset: 0x54A7A0 VA: 0x18054BDA0
	public void set_BackEdgeDilateAmount(float value) { }

	// RVA: 0x54B840 Offset: 0x54A240 VA: 0x18054B840
	public void .ctor() { }

	// RVA: 0x54B940 Offset: 0x54A340 VA: 0x18054B940
	public void .ctor(Renderer renderer, int submesh = 0) { }

	// RVA: 0x54BB00 Offset: 0x54A500 VA: 0x18054BB00
	public void .ctor(Renderer renderer, string cutoutTextureName, float cutoutThreshold = 0.5) { }
}

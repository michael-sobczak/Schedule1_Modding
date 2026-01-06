public class AmplifyImpostorAsset : ScriptableObject // TypeDefIndex: 18779
{
	// Fields
	[SerializeField]
	public Material Material; // 0x18
	[SerializeField]
	public Mesh Mesh; // 0x20
	[HideInInspector]
	[SerializeField]
	public int Version; // 0x28
	[SerializeField]
	public ImpostorType ImpostorType; // 0x2C
	[HideInInspector]
	[SerializeField]
	public bool LockedSizes; // 0x30
	[SerializeField]
	[HideInInspector]
	public int SelectedSize; // 0x34
	[SerializeField]
	public Vector2 TexSize; // 0x38
	[HideInInspector]
	[SerializeField]
	public bool DecoupleAxisFrames; // 0x40
	[Range(1, 32)]
	[SerializeField]
	public int HorizontalFrames; // 0x44
	[Range(1, 33)]
	[SerializeField]
	public int VerticalFrames; // 0x48
	[Range(0, 64)]
	[SerializeField]
	public int PixelPadding; // 0x4C
	[Range(4, 16)]
	[SerializeField]
	public int MaxVertices; // 0x50
	[SerializeField]
	[Range(0, 0.2)]
	public float Tolerance; // 0x54
	[Range(0, 1)]
	[SerializeField]
	public float NormalScale; // 0x58
	[SerializeField]
	public Vector2[] ShapePoints; // 0x60
	[SerializeField]
	public AmplifyImpostorBakePreset Preset; // 0x68
	[SerializeField]
	public List<TextureOutput> OverrideOutput; // 0x70

	// Methods

	// RVA: 0x44D130 Offset: 0x44BB30 VA: 0x18044D130
	public void .ctor() { }
}

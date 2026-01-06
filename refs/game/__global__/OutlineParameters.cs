public class OutlineParameters // TypeDefIndex: 10830
{
	// Fields
	public readonly MeshPool MeshPool; // 0x10
	public Camera Camera; // 0x18
	public RenderTargetIdentifier Target; // 0x20
	public RenderTargetIdentifier DepthTarget; // 0x48
	public CommandBuffer Buffer; // 0x70
	public DilateQuality DilateQuality; // 0x78
	public int DilateIterations; // 0x7C
	public int BlurIterations; // 0x80
	public Vector2 Scale; // 0x84
	public Nullable<Rect> CustomViewport; // 0x8C
	public long OutlineLayerMask; // 0xA0
	public int TargetWidth; // 0xA8
	public int TargetHeight; // 0xAC
	public float BlurShift; // 0xB0
	public float DilateShift; // 0xB4
	public bool UseHDR; // 0xB8
	public bool UseInfoBuffer; // 0xB9
	public bool IsEditorCamera; // 0xBA
	public BufferSizeMode PrimaryBufferSizeMode; // 0xBC
	public int PrimaryBufferSizeReference; // 0xC0
	public float PrimaryBufferScale; // 0xC4
	public StereoTargetEyeMask EyeMask; // 0xC8
	public int Antialiasing; // 0xCC
	public BlurType BlurType; // 0xD0
	public LayerMask Mask; // 0xD4
	public Mesh BlitMesh; // 0xD8
	public List<Outlinable> OutlinablesToRender; // 0xE0
	private bool isInitialized; // 0xE8

	// Methods

	// RVA: 0x54B200 Offset: 0x549C00 VA: 0x18054B200
	public Vector2Int MakeScaledVector(int x, int y) { }

	// RVA: 0x54B190 Offset: 0x549B90 VA: 0x18054B190
	public void CheckInitialization() { }

	// RVA: 0x54B2F0 Offset: 0x549CF0 VA: 0x18054B2F0
	public void Prepare() { }

	// RVA: 0x54B0C0 Offset: 0x549AC0 VA: 0x18054B0C0
	private static bool CheckDiffers(Outlinable outlinable) { }

	// RVA: 0x54B150 Offset: 0x549B50 VA: 0x18054B150
	private static bool CheckIfNonOne(Outlinable.OutlineProperties parameters) { }

	// RVA: 0x54B580 Offset: 0x549F80 VA: 0x18054B580
	public void .ctor() { }
}

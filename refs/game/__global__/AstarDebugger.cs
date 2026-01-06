public class AstarDebugger : VersionedMonoBehaviour // TypeDefIndex: 13160
{
	// Fields
	public int yOffset; // 0x28
	public bool show; // 0x2C
	public bool showInEditor; // 0x2D
	public bool showFPS; // 0x2E
	public bool showPathProfile; // 0x2F
	public bool showMemProfile; // 0x30
	public bool showGraph; // 0x31
	public int graphBufferSize; // 0x34
	public Font font; // 0x38
	public int fontSize; // 0x40
	private StringBuilder text; // 0x48
	private string cachedText; // 0x50
	private float lastUpdate; // 0x58
	private AstarDebugger.GraphPoint[] graph; // 0x60
	private float delayedDeltaTime; // 0x68
	private float lastCollect; // 0x6C
	private float lastCollectNum; // 0x70
	private float delta; // 0x74
	private float lastDeltaTime; // 0x78
	private int allocRate; // 0x7C
	private int lastAllocMemory; // 0x80
	private float lastAllocSet; // 0x84
	private int allocMem; // 0x88
	private int collectAlloc; // 0x8C
	private int peakAlloc; // 0x90
	private int fpsDropCounterSize; // 0x94
	private float[] fpsDrops; // 0x98
	private Rect boxRect; // 0xA0
	private GUIStyle style; // 0xB0
	private Camera cam; // 0xB8
	private float graphWidth; // 0xC0
	private float graphHeight; // 0xC4
	private float graphOffset; // 0xC8
	private int maxVecPool; // 0xCC
	private int maxNodePool; // 0xD0
	private AstarDebugger.PathTypeDebug[] debugTypes; // 0xD8

	// Methods

	// RVA: 0xB08330 Offset: 0xB06D30 VA: 0x180B08330
	public void Start() { }

	// RVA: 0xB06810 Offset: 0xB05210 VA: 0x180B06810
	public void LateUpdate() { }

	// RVA: 0xB06680 Offset: 0xB05080 VA: 0x180B06680
	private void DrawGraphLine(int index, Matrix4x4 m, float x1, float x2, float y1, float y2, Color color) { }

	// RVA: 0xB070C0 Offset: 0xB05AC0 VA: 0x180B070C0
	public void OnGUI() { }

	// RVA: 0xB084F0 Offset: 0xB06EF0 VA: 0x180B084F0
	public void .ctor() { }
}

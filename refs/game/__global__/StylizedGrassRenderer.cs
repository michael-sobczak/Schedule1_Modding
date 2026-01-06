public class StylizedGrassRenderer : MonoBehaviour // TypeDefIndex: 18851
{
	// Fields
	public static StylizedGrassRenderer Instance; // 0x0
	public bool debug; // 0x20
	public RenderTexture vectorRT; // 0x28
	[Tooltip("When a color map is assigned, this will be set as the active color map.

Having the Color Map Renderer component present would not longer be required.")]
	public GrassColorMap colorMap; // 0x30
	[Tooltip("When enabled the grass Ambient and Gust strength values are multiplied by the WindZone's Main value")]
	public bool listenToWindZone; // 0x38
	public WindZone windZone; // 0x40
	public static int _BendMapUV; // 0x8
	private static int _GlobalWindParams; // 0xC
	private static int _GlobalWindDirection; // 0x10
	private double lastFrameTime; // 0x48
	private double timeOffset; // 0x50
	private Vector3 lastDirection; // 0x58
	private Vector3 windDirection; // 0x64

	// Methods

	// RVA: 0x1F64760 Offset: 0x1F63160 VA: 0x181F64760
	public void OnEnable() { }

	// RVA: 0x1F644A0 Offset: 0x1F62EA0 VA: 0x181F644A0
	public void OnDisable() { }

	// RVA: 0x1F64900 Offset: 0x1F63300 VA: 0x181F64900
	public static void SetWindZone(WindZone windZone) { }

	// RVA: 0x1F64E50 Offset: 0x1F63850 VA: 0x181F64E50
	private void Update() { }

	// RVA: 0x1F64A20 Offset: 0x1F63420 VA: 0x181F64A20
	private void UpdateWind() { }

	// RVA: 0x1F645B0 Offset: 0x1F62FB0 VA: 0x181F645B0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x1F645F0 Offset: 0x1F62FF0 VA: 0x181F645F0
	private void OnDrawGizmos() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x1F64E60 Offset: 0x1F63860 VA: 0x181F64E60
	private static void .cctor() { }
}

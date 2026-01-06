public class WaterObject : MonoBehaviour // TypeDefIndex: 18271
{
	// Fields
	public static readonly List<WaterObject> Instances; // 0x0
	public Material material; // 0x20
	public MeshFilter meshFilter; // 0x28
	public MeshRenderer meshRenderer; // 0x30
	private static Vector3 s_PositionOffset; // 0x8
	private static readonly int _WaterPositionOffset; // 0x14
	private static float m_customTimeValue; // 0x18
	private static readonly int CustomTimeID; // 0x1C
	private MaterialPropertyBlock _props; // 0x38

	// Properties
	internal static Vector3 PositionOffset { get; set; }
	public static float CustomTime { get; set; }
	public MaterialPropertyBlock props { get; set; }

	// Methods

	// RVA: 0x1F731D0 Offset: 0x1F71BD0 VA: 0x181F731D0
	public static void set_PositionOffset(Vector3 value) { }

	// RVA: 0x1F73050 Offset: 0x1F71A50 VA: 0x181F73050
	internal static Vector3 get_PositionOffset() { }

	// RVA: 0x1F73150 Offset: 0x1F71B50 VA: 0x181F73150
	public static void set_CustomTime(float value) { }

	// RVA: 0x1F73000 Offset: 0x1F71A00 VA: 0x181F73000
	public static float get_CustomTime() { }

	// RVA: 0x1F730C0 Offset: 0x1F71AC0 VA: 0x181F730C0
	public MaterialPropertyBlock get_props() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_props(MaterialPropertyBlock value) { }

	// RVA: 0x1F72270 Offset: 0x1F70C70 VA: 0x181F72270
	private void CreatePropertyBlock(Renderer sourceRenderer) { }

	// RVA: 0x1F72E20 Offset: 0x1F71820 VA: 0x181F72E20
	private void Reset() { }

	// RVA: 0x1F72C00 Offset: 0x1F71600 VA: 0x181F72C00
	private void OnEnable() { }

	// RVA: 0x1F72B80 Offset: 0x1F71580 VA: 0x181F72B80
	private void OnDisable() { }

	// RVA: 0x1F72CD0 Offset: 0x1F716D0 VA: 0x181F72CD0
	private void OnValidate() { }

	// RVA: 0x1F72300 Offset: 0x1F70D00 VA: 0x181F72300
	public Material FetchWaterMaterial() { }

	// RVA: 0x1F71F60 Offset: 0x1F70960 VA: 0x181F71F60
	public void ApplyInstancedProperties() { }

	// RVA: 0x1F720E0 Offset: 0x1F70AE0 VA: 0x181F720E0
	public bool CanTouch(Vector3 position) { }

	// RVA: 0x1F72050 Offset: 0x1F70A50 VA: 0x181F72050
	public void AssignMesh(Mesh mesh) { }

	// RVA: 0x1F71FB0 Offset: 0x1F709B0 VA: 0x181F71FB0
	public void AssignMaterial(Material newMaterial) { }

	// RVA: 0x1F72850 Offset: 0x1F71250 VA: 0x181F72850
	public static WaterObject New(Material waterMaterial, Mesh mesh) { }

	// RVA: 0x1F723A0 Offset: 0x1F70DA0 VA: 0x181F723A0
	public static WaterObject Find(Vector3 position, bool rotationSupport) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x1F72F10 Offset: 0x1F71910 VA: 0x181F72F10
	private static void .cctor() { }
}

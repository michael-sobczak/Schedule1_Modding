public class Eye : MonoBehaviour // TypeDefIndex: 3110
{
	// Fields
	public const float PupilLookSpeed = 10;
	private static Vector3 defaultScale; // 0x0
	private static Vector3 maxRotation; // 0xC
	private static Vector3 minRotation; // 0x18
	[CompilerGenerated]
	private Eye.EyeLidConfiguration <CurrentConfiguration>k__BackingField; // 0x20
	[Header("References")]
	public Transform Container; // 0x28
	public Transform TopLidContainer; // 0x30
	public Transform BottomLidContainer; // 0x38
	public Transform PupilContainer; // 0x40
	public MeshRenderer TopLidRend; // 0x48
	public MeshRenderer BottomLidRend; // 0x50
	public MeshRenderer EyeBallRend; // 0x58
	public Transform EyeLookOrigin; // 0x60
	public OptimizedLight EyeLight; // 0x68
	public SkinnedMeshRenderer PupilRend; // 0x70
	private Coroutine blinkRoutine; // 0x78
	private Coroutine stateRoutine; // 0x80
	private Avatar avatar; // 0x88
	private Color defaultEyeColor; // 0x90
	public Vector2 AngleOffset; // 0xA0

	// Properties
	public Eye.EyeLidConfiguration CurrentConfiguration { get; set; }
	public bool IsBlinking { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F5860 Offset: 0x4F4260 VA: 0x1804F5860
	public Eye.EyeLidConfiguration get_CurrentConfiguration() { }

	[CompilerGenerated]
	// RVA: 0x4F58D0 Offset: 0x4F42D0 VA: 0x1804F58D0
	protected void set_CurrentConfiguration(Eye.EyeLidConfiguration value) { }

	// RVA: 0x9BB2B0 Offset: 0x9B9CB0 VA: 0x1809BB2B0
	public bool get_IsBlinking() { }

	// RVA: 0x9B9D90 Offset: 0x9B8790 VA: 0x1809B9D90
	private void Awake() { }

	// RVA: 0x9BB060 Offset: 0x9B9A60 VA: 0x1809BB060
	public void SetSize(float size) { }

	// RVA: 0x9BAFE0 Offset: 0x9B99E0 VA: 0x1809BAFE0
	public void SetLidColor(Color color) { }

	// RVA: 0x9BAFC0 Offset: 0x9B99C0 VA: 0x1809BAFC0
	public void SetEyeballMaterial(Material mat) { }

	// RVA: 0x9BAEA0 Offset: 0x9B98A0 VA: 0x1809BAEA0
	public void SetEyeballColor(Color col, float emission = 0.115, bool writeDefault = True) { }

	// RVA: 0x9BA890 Offset: 0x9B9290 VA: 0x1809BA890
	public void ResetEyeballColor() { }

	// RVA: 0x9BA050 Offset: 0x9B8A50 VA: 0x1809BA050
	public void ConfigureEyeLight(Color color, float intensity) { }

	// RVA: 0x9BA990 Offset: 0x9B9390 VA: 0x1809BA990
	public void SetDilation(float dil) { }

	// RVA: 0x9BA9C0 Offset: 0x9B93C0 VA: 0x1809BA9C0
	public void SetEyeLidState(Eye.EyeLidConfiguration config, float time) { }

	// RVA: 0x9BB120 Offset: 0x9B9B20 VA: 0x1809BB120
	private void StopExistingRoutines() { }

	// RVA: 0x9BABC0 Offset: 0x9B95C0 VA: 0x1809BABC0
	public void SetEyeLidState(Eye.EyeLidConfiguration config, bool debug = False) { }

	// RVA: 0x9BA170 Offset: 0x9B8B70 VA: 0x1809BA170
	public void LookAt(Vector3 position, bool instant = False) { }

	// RVA: 0x9B9E00 Offset: 0x9B8800 VA: 0x1809B9E00
	public void Blink(float blinkDuration, Eye.EyeLidConfiguration endState, bool debug = False) { }

	// RVA: 0x9BB240 Offset: 0x9B9C40 VA: 0x1809BB240
	public void .ctor() { }

	// RVA: 0x9BB190 Offset: 0x9B9B90 VA: 0x1809BB190
	private static void .cctor() { }
}

public class GlobalWind : MonoBehaviour // TypeDefIndex: 18222
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static GlobalWind <Instance>k__BackingField; // 0x0
	[SerializeField]
	private WindSettings _windSettings; // 0x20
	[SerializeField]
	private WindZone _sourceWindZone; // 0x38
	[SerializeField]
	private Texture2D _gustNoise; // 0x40
	[HideInInspector]
	[SerializeField]
	private int _selectedPreset; // 0x48
	private Quaternion _cachedRotation; // 0x4C
	private float _cachedWindMain; // 0x5C
	private float _cachedWindPulseFrequency; // 0x60
	private float _cachedWindTurbulence; // 0x64
	private double _smoothWindOffset; // 0x68
	private double _cachedTime; // 0x70
	private Vector2 _windOffset; // 0x78
	private Vector2 _prevWindOffset; // 0x80
	private Vector2 _direction; // 0x88
	private Vector2 _directionVelocity; // 0x90
	private float _strength; // 0x98
	private float _strengthVelocity; // 0x9C
	private float _speed; // 0xA0
	private float _speedVelocity; // 0xA4
	private float _turbulence; // 0xA8
	private float _turbulenceVelocity; // 0xAC

	// Properties
	public static GlobalWind Instance { get; set; }
	public WindSettings Settings { get; set; }
	public WindZone Zone { get; set; }
	public Texture2D GustNoise { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2F625D0 Offset: 0x2F60FD0 VA: 0x182F625D0
	public static GlobalWind get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x2F62680 Offset: 0x2F61080 VA: 0x182F62680
	private static void set_Instance(GlobalWind value) { }

	// RVA: 0x2F62610 Offset: 0x2F61010 VA: 0x182F62610
	public WindSettings get_Settings() { }

	// RVA: 0x2F626E0 Offset: 0x2F610E0 VA: 0x182F626E0
	public void set_Settings(WindSettings value) { }

	// RVA: 0x2D0E1B0 Offset: 0x2D0CBB0 VA: 0x182D0E1B0
	public WindZone get_Zone() { }

	// RVA: 0x2F627D0 Offset: 0x2F611D0 VA: 0x182F627D0
	public void set_Zone(WindZone value) { }

	// RVA: 0x2D06A80 Offset: 0x2D05480 VA: 0x182D06A80
	public Texture2D get_GustNoise() { }

	// RVA: 0x2F62630 Offset: 0x2F61030 VA: 0x182F62630
	public void set_GustNoise(Texture2D value) { }

	// RVA: 0x2F619F0 Offset: 0x2F603F0 VA: 0x182F619F0
	public void SetFloatingOrigin(double x, double z) { }

	// RVA: 0x2F62540 Offset: 0x2F60F40 VA: 0x182F62540
	private float Wrap(double value, double range) { }

	// RVA: 0x2F61D70 Offset: 0x2F60770 VA: 0x182F61D70
	public void UpdateTime(double time) { }

	// RVA: 0x2F618F0 Offset: 0x2F602F0 VA: 0x182F618F0
	private void OnEnable() { }

	// RVA: 0x2F62180 Offset: 0x2F60B80 VA: 0x182F62180
	private void Update() { }

	// RVA: 0x2F616C0 Offset: 0x2F600C0 VA: 0x182F616C0
	private void CopyAndApply() { }

	// RVA: 0x2F61750 Offset: 0x2F60150 VA: 0x182F61750
	private void CopyFromWindZone() { }

	// RVA: 0x2F62430 Offset: 0x2F60E30 VA: 0x182F62430
	private bool WindZoneHasChanged() { }

	// RVA: 0x2F61640 Offset: 0x2F60040 VA: 0x182F61640
	private void CacheWindZoneProperties() { }

	// RVA: 0x2F62340 Offset: 0x2F60D40 VA: 0x182F62340
	private void ValidateWindZone() { }

	// RVA: 0x2F61C00 Offset: 0x2F60600 VA: 0x182F61C00
	private void UpdateDirection(bool useCache) { }

	// RVA: 0x2F62570 Offset: 0x2F60F70 VA: 0x182F62570
	public void .ctor() { }
}

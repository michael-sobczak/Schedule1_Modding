public class OptimizedLight : MonoBehaviour // TypeDefIndex: 1919
{
	// Fields
	[FormerlySerializedAs("Enabled")]
	[SerializeField]
	private bool _Enabled; // 0x20
	[FormerlySerializedAs("DisabledForOptimization")]
	[HideInInspector]
	[SerializeField]
	private bool _DisabledForOptimization; // 0x21
	[Range(10, 500)]
	public float MaxDistance; // 0x24
	public Light _Light; // 0x28
	private bool culled; // 0x30
	private float maxDistanceSquared; // 0x34

	// Properties
	public bool Enabled { get; set; }
	public bool DisabledForOptimization { get; set; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Enabled() { }

	// RVA: 0x78E0B0 Offset: 0x78CAB0 VA: 0x18078E0B0
	public void set_Enabled(bool value) { }

	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_DisabledForOptimization() { }

	// RVA: 0x78E0A0 Offset: 0x78CAA0 VA: 0x18078E0A0
	public void set_DisabledForOptimization(bool value) { }

	// RVA: 0x78D890 Offset: 0x78C290 VA: 0x18078D890 Slot: 4
	public virtual void Awake() { }

	// RVA: 0x78DA20 Offset: 0x78C420 VA: 0x18078DA20
	private void Start() { }

	// RVA: 0x78D8F0 Offset: 0x78C2F0 VA: 0x18078D8F0
	private void OnDestroy() { }

	// RVA: 0x78DE60 Offset: 0x78C860 VA: 0x18078DE60
	private void UpdateCull() { }

	// RVA: 0x78D9F0 Offset: 0x78C3F0 VA: 0x18078D9F0
	public void SetEnabled(bool enabled) { }

	// RVA: 0x78DFF0 Offset: 0x78C9F0 VA: 0x18078DFF0
	private void UpdateLightState() { }

	// RVA: 0x78E080 Offset: 0x78CA80 VA: 0x18078E080
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x78DB90 Offset: 0x78C590 VA: 0x18078DB90
	private void <Start>g__Register|13_0() { }
}

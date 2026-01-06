public class Fillable : MonoBehaviour // TypeDefIndex: 2420
{
	// Fields
	[CompilerGenerated]
	private List<Fillable.Content> <contents>k__BackingField; // 0x20
	[Header("References")]
	public LiquidContainer LiquidContainer; // 0x28
	[Header("Settings")]
	public bool FillableEnabled; // 0x30
	public float LiquidCapacity_L; // 0x34

	// Properties
	public List<Fillable.Content> contents { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<Fillable.Content> get_contents() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_contents(List<Fillable.Content> value) { }

	// RVA: 0x871050 Offset: 0x86FA50 VA: 0x180871050
	private void Awake() { }

	// RVA: 0x870E60 Offset: 0x86F860 VA: 0x180870E60
	public void AddLiquid(string label, float volume, Color color) { }

	// RVA: 0x8712A0 Offset: 0x86FCA0 VA: 0x1808712A0
	public void ResetContents() { }

	// RVA: 0x871310 Offset: 0x86FD10 VA: 0x180871310
	private void UpdateLiquid() { }

	// RVA: 0x871080 Offset: 0x86FA80 VA: 0x180871080
	public float GetLiquidVolume(string label) { }

	// RVA: 0x871180 Offset: 0x86FB80 VA: 0x180871180
	public float GetTotalLiquidVolume() { }

	// RVA: 0x871580 Offset: 0x86FF80 VA: 0x180871580
	public void .ctor() { }
}

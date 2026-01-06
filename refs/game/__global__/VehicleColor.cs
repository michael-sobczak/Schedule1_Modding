public class VehicleColor : MonoBehaviour // TypeDefIndex: 2180
{
	// Fields
	public VehicleColor.BodyMesh[] BodyMeshes; // 0x20
	public EVehicleColor DefaultColor; // 0x28
	private EVehicleColor displayedColor; // 0x2C
	private bool initialColorApplied; // 0x30

	// Methods

	// RVA: 0x837740 Offset: 0x836140 VA: 0x180837740
	private void Start() { }

	// RVA: 0x837430 Offset: 0x835E30 VA: 0x180837430 Slot: 4
	public virtual void ApplyColor(EVehicleColor col) { }

	// RVA: 0x837780 Offset: 0x836180 VA: 0x180837780
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x837760 Offset: 0x836160 VA: 0x180837760
	private bool <ApplyColor>b__6_0(VehicleColors.VehicleColorData x) { }
}

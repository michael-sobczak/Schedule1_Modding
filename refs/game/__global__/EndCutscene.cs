public class EndCutscene : Cutscene // TypeDefIndex: 1980
{
	// Fields
	public UnityEvent onStandUp; // 0x58
	public UnityEvent onRunStart; // 0x60
	public UnityEvent onEngineStart; // 0x68
	public UnityEvent onLightsOn; // 0x70
	public Avatar Avatar; // 0x78

	// Methods

	// RVA: 0x79B240 Offset: 0x799C40 VA: 0x18079B240 Slot: 5
	public override void Play() { }

	// RVA: 0x79B2F0 Offset: 0x799CF0 VA: 0x18079B2F0
	public void StandUp() { }

	// RVA: 0x79B2D0 Offset: 0x799CD0 VA: 0x18079B2D0
	public void RunStart() { }

	// RVA: 0x79B180 Offset: 0x799B80 VA: 0x18079B180
	public void EngineStart() { }

	// RVA: 0x79B1A0 Offset: 0x799BA0 VA: 0x18079B1A0
	public void LightsOn() { }

	// RVA: 0x79B1C0 Offset: 0x799BC0 VA: 0x18079B1C0
	public void On3rdPerson() { }

	// RVA: 0x7983D0 Offset: 0x796DD0 VA: 0x1807983D0
	public void .ctor() { }
}

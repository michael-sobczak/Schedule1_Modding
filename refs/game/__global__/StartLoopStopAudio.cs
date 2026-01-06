public class StartLoopStopAudio : MonoBehaviour // TypeDefIndex: 2162
{
	// Fields
	[CompilerGenerated]
	private bool <Runnning>k__BackingField; // 0x20
	public AudioSourceController StartSound; // 0x28
	public AudioSourceController LoopSound; // 0x30
	public AudioSourceController StopSound; // 0x38
	public bool FadeLoopIn; // 0x40
	public bool FadeLoopOut; // 0x41
	private float timeSinceStart; // 0x44
	private float timeSinceStop; // 0x48

	// Properties
	public bool Runnning { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Runnning() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_Runnning(bool value) { }

	// RVA: 0x822FE0 Offset: 0x8219E0 VA: 0x180822FE0
	private void Update() { }

	[Button]
	// RVA: 0x822EF0 Offset: 0x8218F0 VA: 0x180822EF0
	public void StartAudio() { }

	[Button]
	// RVA: 0x822F70 Offset: 0x821970 VA: 0x180822F70
	public void StopAudio() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

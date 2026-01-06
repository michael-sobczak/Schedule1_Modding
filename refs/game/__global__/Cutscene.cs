public class Cutscene : MonoBehaviour // TypeDefIndex: 1977
{
	// Fields
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; // 0x20
	[Header("Settings")]
	public string Name; // 0x28
	public bool DisablePlayerControl; // 0x30
	public bool OverrideFOV; // 0x31
	public float CameraFOV; // 0x34
	[Header("References")]
	public Transform CameraControl; // 0x38
	[Header("Events")]
	public UnityEvent onPlay; // 0x40
	public UnityEvent onEnd; // 0x48
	private Animation animation; // 0x50

	// Properties
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsPlaying(bool value) { }

	// RVA: 0x797B00 Offset: 0x796500 VA: 0x180797B00 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x797EC0 Offset: 0x7968C0 VA: 0x180797EC0
	private void LateUpdate() { }

	// RVA: 0x798030 Offset: 0x796A30 VA: 0x180798030 Slot: 5
	public virtual void Play() { }

	// RVA: 0x797B50 Offset: 0x796550 VA: 0x180797B50
	public void InvokeEnd() { }

	// RVA: 0x7983D0 Offset: 0x796DD0 VA: 0x1807983D0
	public void .ctor() { }
}

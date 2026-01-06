public class MusicTrack : MonoBehaviour // TypeDefIndex: 2154
{
	// Fields
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; // 0x20
	public bool Enabled; // 0x21
	public string TrackName; // 0x28
	public int Priority; // 0x30
	public float FadeInTime; // 0x34
	public float FadeOutTime; // 0x38
	public AudioSourceController Controller; // 0x40
	public float VolumeMultiplier; // 0x48
	public bool AutoFadeOut; // 0x4C
	protected float volumeMultiplier; // 0x50

	// Properties
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsPlaying(bool value) { }

	// RVA: 0x820C70 Offset: 0x81F670 VA: 0x180820C70
	private void OnValidate() { }

	// RVA: 0x820C60 Offset: 0x81F660 VA: 0x180820C60
	public void Enable() { }

	// RVA: 0x820C50 Offset: 0x81F650 VA: 0x180820C50
	public void Disable() { }

	// RVA: 0x820C40 Offset: 0x81F640 VA: 0x180820C40 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x820D40 Offset: 0x81F740 VA: 0x180820D40 Slot: 5
	public virtual void Update() { }

	// RVA: 0x820D10 Offset: 0x81F710 VA: 0x180820D10 Slot: 6
	public virtual void Play() { }

	// RVA: 0x77D410 Offset: 0x77BE10 VA: 0x18077D410 Slot: 7
	public virtual void Stop() { }

	// RVA: 0x820EB0 Offset: 0x81F8B0 VA: 0x180820EB0
	public void .ctor() { }
}

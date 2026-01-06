public class ButtonSound : MonoBehaviour // TypeDefIndex: 2139
{
	// Fields
	public AudioSourceController AudioSource; // 0x20
	public EventTrigger EventTrigger; // 0x28
	public bool PlaySoundOnClickStart; // 0x30
	[Header("Clips")]
	public AudioClip HoverClip; // 0x38
	public float HoverSoundVolume; // 0x40
	public AudioClip ClickClip; // 0x48
	public float ClickSoundVolume; // 0x50
	private Button Button; // 0x58

	// Methods

	// RVA: 0x810A00 Offset: 0x80F400 VA: 0x180810A00
	public void Awake() { }

	// RVA: 0x810C60 Offset: 0x80F660 VA: 0x180810C60
	private void OnValidate() { }

	// RVA: 0x810850 Offset: 0x80F250 VA: 0x180810850
	public void AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Action action) { }

	// RVA: 0x810BC0 Offset: 0x80F5C0 VA: 0x180810BC0 Slot: 4
	protected virtual void Hovered() { }

	// RVA: 0x810B40 Offset: 0x80F540 VA: 0x180810B40 Slot: 5
	protected virtual void Clicked() { }

	// RVA: 0x810D40 Offset: 0x80F740 VA: 0x180810D40
	public void .ctor() { }
}

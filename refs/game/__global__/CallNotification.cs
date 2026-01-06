public class CallNotification : Singleton<CallNotification> // TypeDefIndex: 2802
{
	// Fields
	public const float TIME_PER_CHAR = 0.015;
	[CompilerGenerated]
	private PhoneCallData <ActiveCallData>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x30
	[Header("References")]
	public RectTransform Container; // 0x38
	public Image ProfilePicture; // 0x40
	public CanvasGroup Group; // 0x48
	private Coroutine slideRoutine; // 0x50

	// Properties
	public PhoneCallData ActiveCallData { get; set; }
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public PhoneCallData get_ActiveCallData() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_ActiveCallData(PhoneCallData value) { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	protected void set_IsOpen(bool value) { }

	// RVA: 0x9267B0 Offset: 0x9251B0 VA: 0x1809267B0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x926860 Offset: 0x925260 VA: 0x180926860
	public void SetIsOpen(bool visible, CallerID caller) { }

	// RVA: 0x926980 Offset: 0x925380 VA: 0x180926980
	public void .ctor() { }
}

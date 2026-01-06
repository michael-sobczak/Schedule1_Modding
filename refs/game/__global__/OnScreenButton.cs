public class OnScreenButton : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler // TypeDefIndex: 7541
{
	// Fields
	[InputControl(layout = "Button")]
	[SerializeField]
	private string m_ControlPath; // 0x38

	// Properties
	protected override string controlPathInternal { get; set; }

	// Methods

	// RVA: 0x284AC90 Offset: 0x2849690 VA: 0x18284AC90 Slot: 9
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x284AC40 Offset: 0x2849640 VA: 0x18284AC40 Slot: 8
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 4
	protected override string get_controlPathInternal() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0 Slot: 5
	protected override void set_controlPathInternal(string value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

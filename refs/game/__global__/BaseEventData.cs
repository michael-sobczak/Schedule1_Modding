public class BaseEventData : AbstractEventData // TypeDefIndex: 16517
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Properties
	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }

	// Methods

	// RVA: 0x7E2C80 Offset: 0x7E1680 VA: 0x1807E2C80
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1DF3CB0 Offset: 0x1DF26B0 VA: 0x181DF3CB0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x1DF3C60 Offset: 0x1DF2660 VA: 0x181DF3C60
	public GameObject get_selectedObject() { }

	// RVA: 0x2F44510 Offset: 0x2F42F10 VA: 0x182F44510
	public void set_selectedObject(GameObject value) { }
}

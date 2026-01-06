public class SettingsSlider : MonoBehaviour // TypeDefIndex: 2769
{
	// Fields
	private const float VALUE_DISPLAY_TIME = 2;
	public bool DisplayValue; // 0x20
	protected Slider slider; // 0x28
	protected TextMeshProUGUI valueLabel; // 0x30
	protected float timeOnValueChange; // 0x38

	// Methods

	// RVA: 0x93B2F0 Offset: 0x939CF0 VA: 0x18093B2F0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x93B4D0 Offset: 0x939ED0 VA: 0x18093B4D0 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x93B440 Offset: 0x939E40 VA: 0x18093B440 Slot: 6
	protected virtual void OnValueChanged(float value) { }

	// RVA: 0x93B420 Offset: 0x939E20 VA: 0x18093B420 Slot: 7
	protected virtual string GetDisplayValue(float value) { }

	// RVA: 0x926B40 Offset: 0x925540 VA: 0x180926B40
	public void .ctor() { }
}

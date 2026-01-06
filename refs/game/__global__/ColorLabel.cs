public class ColorLabel : MonoBehaviour // TypeDefIndex: 18745
{
	// Fields
	public ColorPicker picker; // 0x20
	public ColorValues type; // 0x28
	public string prefix; // 0x30
	public float minValue; // 0x38
	public float maxValue; // 0x3C
	public int precision; // 0x40
	[HideInInspector]
	[SerializeField]
	private TMP_Text label; // 0x48

	// Methods

	// RVA: 0x1A492E0 Offset: 0x1A47CE0 VA: 0x181A492E0
	private void Awake() { }

	// RVA: 0x1A49570 Offset: 0x1A47F70 VA: 0x181A49570
	private void OnEnable() { }

	// RVA: 0x1A49420 Offset: 0x1A47E20 VA: 0x181A49420
	private void OnDestroy() { }

	// RVA: 0x1A49330 Offset: 0x1A47D30 VA: 0x181A49330
	private void ColorChanged(Color color) { }

	// RVA: 0x1A49330 Offset: 0x1A47D30 VA: 0x181A49330
	private void HSVChanged(float hue, float sateration, float value) { }

	// RVA: 0x1A496F0 Offset: 0x1A480F0 VA: 0x181A496F0
	private void UpdateValue() { }

	// RVA: 0x1A49340 Offset: 0x1A47D40 VA: 0x181A49340
	private string ConvertToDisplayString(float value) { }

	// RVA: 0x1A49980 Offset: 0x1A48380 VA: 0x181A49980
	public void .ctor() { }
}

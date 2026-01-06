public class TemperatureDisplay : MonoBehaviour // TypeDefIndex: 2707
{
	// Fields
	public const float MaxCameraDistance = 8;
	public const float MinCameraDistance = 0.5;
	public const float FadeInDistance = 2;
	public const float FadeOutDistance = 0.25;
	public bool UseColor; // 0x20
	[SerializeField]
	private Gradient _temperatureColorGradient; // 0x28
	[SerializeField]
	private TextMeshPro _label; // 0x30
	private Func<float> _getCelsiusTemperature; // 0x38
	private Func<bool> _getIsVisible; // 0x40

	// Methods

	// RVA: 0x91A240 Offset: 0x918C40 VA: 0x18091A240
	private void Awake() { }

	// RVA: 0x91A270 Offset: 0x918C70 VA: 0x18091A270
	private void LateUpdate() { }

	// RVA: 0x91A280 Offset: 0x918C80 VA: 0x18091A280
	private void UpdateCanvas() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void SetTemperatureGetter(Func<float> getCelsiusTemperature) { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void SetVisibilityGetter(Func<bool> getIsVisible) { }

	// RVA: 0x86BF20 Offset: 0x86A920 VA: 0x18086BF20
	public void SetEnabled(bool enabled) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

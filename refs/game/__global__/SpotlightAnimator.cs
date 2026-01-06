public class SpotlightAnimator : MonoBehaviour // TypeDefIndex: 379
{
	// Fields
	public float lightOnDelay; // 0x20
	public float targetIntensity; // 0x24
	public float initialIntensity; // 0x28
	public float duration; // 0x2C
	public float nextColorInterval; // 0x30
	public float colorChangeDuration; // 0x34
	private Light spotLight; // 0x38
	private float lastColorChange; // 0x40
	private float colorChangeStarted; // 0x44
	private Color currentColor; // 0x48
	private Color nextColor; // 0x58
	private bool changingColor; // 0x68

	// Methods

	// RVA: 0x8D8900 Offset: 0x8D7300 VA: 0x1808D8900
	private void Awake() { }

	// RVA: 0x8D8970 Offset: 0x8D7370 VA: 0x1808D8970
	private void Update() { }

	// RVA: 0x8D8BF0 Offset: 0x8D75F0 VA: 0x1808D8BF0
	public void .ctor() { }
}

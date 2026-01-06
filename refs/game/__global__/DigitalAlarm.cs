public class DigitalAlarm : MonoBehaviour // TypeDefIndex: 3312
{
	// Fields
	public const float FLASH_FREQUENCY = 4;
	public MeshRenderer ScreenMesh; // 0x20
	public int ScreenMeshMaterialIndex; // 0x28
	public TextMeshPro ScreenText; // 0x30
	public bool FlashScreen; // 0x38
	[Header("Settings")]
	public bool DisplayCurrentTime; // 0x39
	public Material ScreenOffMat; // 0x40
	public Material ScreenOnMat; // 0x48
	private bool isLit; // 0x50

	// Methods

	// RVA: 0xA4ABF0 Offset: 0xA495F0 VA: 0x180A4ABF0
	private void Start() { }

	// RVA: 0xA4A9A0 Offset: 0xA493A0 VA: 0x180A4A9A0
	private void OnDestroy() { }

	// RVA: 0xA4AB20 Offset: 0xA49520 VA: 0x180A4AB20
	public void SetScreenLit(bool lit) { }

	// RVA: 0xA4A7B0 Offset: 0xA491B0 VA: 0x180A4A7B0
	public void DisplayText(string text) { }

	// RVA: 0xA4A6D0 Offset: 0xA490D0 VA: 0x180A4A6D0
	public void DisplayMinutes(int mins) { }

	// RVA: 0xA4A8E0 Offset: 0xA492E0 VA: 0x180A4A8E0
	private void MinPass() { }

	// RVA: 0xA4A7E0 Offset: 0xA491E0 VA: 0x180A4A7E0
	private void FixedUpdate() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

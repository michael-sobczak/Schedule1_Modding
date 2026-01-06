public class ConfirmDisplaySettings : MonoBehaviour // TypeDefIndex: 2755
{
	// Fields
	public const float RevertTime = 15;
	public TextMeshProUGUI SubtitleLabel; // 0x20
	private float timeUntilRevert; // 0x28
	private DisplaySettings oldSettings; // 0x2C
	private DisplaySettings newSettings; // 0x4C

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x927160 Offset: 0x925B60 VA: 0x180927160
	public bool get_IsOpen() { }

	// RVA: 0x926B60 Offset: 0x925560 VA: 0x180926B60
	public void Awake() { }

	// RVA: 0x926F70 Offset: 0x925970 VA: 0x180926F70
	public void Open(DisplaySettings _oldSettings, DisplaySettings _newSettings) { }

	// RVA: 0x926E80 Offset: 0x925880 VA: 0x180926E80
	public void Exit(ExitAction action) { }

	// RVA: 0x927090 Offset: 0x925A90 VA: 0x180927090
	public void Update() { }

	// RVA: 0x926C20 Offset: 0x925620 VA: 0x180926C20
	public void Close(bool revert) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

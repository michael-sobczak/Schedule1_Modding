public class CharacterCreatorMenu : MonoBehaviour // TypeDefIndex: 2980
{
	// Fields
	public CharacterCreatorMenu.Window[] Windows; // 0x20
	[Header("References")]
	public TextMeshProUGUI CategoryLabel; // 0x28
	public Button BackButton; // 0x30
	public Button NextButton; // 0x38
	private int openWindowIndex; // 0x40
	private CharacterCreatorMenu.Window openWindow; // 0x48

	// Methods

	// RVA: 0x977940 Offset: 0x976340 VA: 0x180977940
	public void Start() { }

	// RVA: 0x977820 Offset: 0x976220 VA: 0x180977820
	public void OpenWindow(int index) { }

	// RVA: 0x977800 Offset: 0x976200 VA: 0x180977800
	public void Back() { }

	// RVA: 0x977810 Offset: 0x976210 VA: 0x180977810
	public void Next() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

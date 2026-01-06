public class InputPromptsManager : Singleton<InputPromptsManager> // TypeDefIndex: 2953
{
	// Fields
	[Header("Input Prompt Prefabs")]
	public GameObject KeyPromptPrefab; // 0x28
	public GameObject WideKeyPromptPrefab; // 0x30
	public GameObject ExtraWideKeyPromptPrefab; // 0x38
	public GameObject LeftClickPromptPrefab; // 0x40
	public GameObject MiddleClickPromptPrefab; // 0x48
	public GameObject RightClickPromptPrefab; // 0x50

	// Methods

	// RVA: 0x960D50 Offset: 0x95F750 VA: 0x180960D50
	public PromptImage GetPromptImage(string controlPath, RectTransform parent) { }

	// RVA: 0x9610F0 Offset: 0x95FAF0 VA: 0x1809610F0
	private bool IsControlPathMouseRelated(string controlPath) { }

	// RVA: 0x961180 Offset: 0x95FB80 VA: 0x180961180
	private bool IsControlPathWideKey(string controlPath) { }

	// RVA: 0x9610A0 Offset: 0x95FAA0 VA: 0x1809610A0
	private bool IsControlPathExtraWideKey(string controlPath) { }

	// RVA: 0x95F6A0 Offset: 0x95E0A0 VA: 0x18095F6A0
	public string GetDisplayNameForControlPath(string controlPath) { }

	// RVA: 0x961390 Offset: 0x95FD90 VA: 0x180961390
	public void .ctor() { }
}

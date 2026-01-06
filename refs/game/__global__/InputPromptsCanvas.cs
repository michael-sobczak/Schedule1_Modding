public class InputPromptsCanvas : Singleton<InputPromptsCanvas> // TypeDefIndex: 2625
{
	// Fields
	public RectTransform InputPromptsContainer; // 0x28
	[Header("Input prompt modules")]
	public List<InputPromptsCanvas.Module> Modules; // 0x30
	[CompilerGenerated]
	private string <currentModuleLabel>k__BackingField; // 0x38
	[CompilerGenerated]
	private RectTransform <currentModule>k__BackingField; // 0x40

	// Properties
	public string currentModuleLabel { get; set; }
	public RectTransform currentModule { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_currentModuleLabel() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_currentModuleLabel(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public RectTransform get_currentModule() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_currentModule(RectTransform value) { }

	// RVA: 0x8E9340 Offset: 0x8E7D40 VA: 0x1808E9340
	public void LoadModule(string key) { }

	// RVA: 0x8E9580 Offset: 0x8E7F80 VA: 0x1808E9580
	public void UnloadModule() { }

	// RVA: 0x8E9640 Offset: 0x8E8040 VA: 0x1808E9640
	public void .ctor() { }
}

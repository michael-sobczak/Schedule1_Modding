public class OkButtonClickedEventArgs : CancelEventArgs // TypeDefIndex: 17292
{
	// Fields
	private string _input; // 0x18
	private IWin32Window _inputBoxWindow; // 0x20

	// Properties
	public string Input { get; }
	public IWin32Window InputBoxWindow { get; }

	// Methods

	// RVA: 0x1E09810 Offset: 0x1E08210 VA: 0x181E09810
	public void .ctor(string input, IWin32Window inputBoxWindow) { }

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public string get_Input() { }

	// RVA: 0x1E09860 Offset: 0x1E08260 VA: 0x181E09860
	public IWin32Window get_InputBoxWindow() { }
}

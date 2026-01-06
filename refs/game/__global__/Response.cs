public class Response // TypeDefIndex: 1174
{
	// Fields
	public string text; // 0x10
	public string label; // 0x18
	[CodegenExclude]
	public Action callback; // 0x20
	public bool disableDefaultResponseBehaviour; // 0x28

	// Methods

	// RVA: 0x608D60 Offset: 0x607760 VA: 0x180608D60
	public void .ctor(string _text, string _label, Action _callback, bool _disableDefaultResponseBehaviour = False) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}

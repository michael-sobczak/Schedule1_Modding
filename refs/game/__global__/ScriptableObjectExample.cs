public class ScriptableObjectExample : ScriptableObject // TypeDefIndex: 502
{
	// Methods

	[Button]
	// RVA: 0xA8CB90 Offset: 0xA8B590 VA: 0x180A8CB90
	public void SayHello() { }

	[Button(Mode = 2)]
	// RVA: 0xA8CAD0 Offset: 0xA8B4D0 VA: 0x180A8CAD0
	public void SayHelloEditor() { }

	[Button(Mode = 1)]
	// RVA: 0xA8CB30 Offset: 0xA8B530 VA: 0x180A8CB30
	public void SayHelloPlayMode() { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }
}

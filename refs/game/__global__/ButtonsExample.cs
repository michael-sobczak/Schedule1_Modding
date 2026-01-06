public class ButtonsExample : MonoBehaviour // TypeDefIndex: 500
{
	// Methods

	[Button]
	// RVA: 0xA7BD80 Offset: 0xA7A780 VA: 0x180A7BD80
	public void SayMyName() { }

	[Button(Mode = 2)]
	// RVA: 0xA7BCC0 Offset: 0xA7A6C0 VA: 0x180A7BCC0
	protected void SayHelloEditor() { }

	[Button(Mode = 1)]
	// RVA: 0xA7BD20 Offset: 0xA7A720 VA: 0x180A7BD20
	private void SayHelloInRuntime() { }

	[Button("Special Name", Spacing = 1)]
	// RVA: 0xA7BE40 Offset: 0xA7A840 VA: 0x180A7BE40
	private void TestButtonName() { }

	[Button("Special Name Editor Only", Mode = 2)]
	// RVA: 0xA7BDE0 Offset: 0xA7A7E0 VA: 0x180A7BDE0
	private void TestButtonNameEditorOnly() { }

	[Button]
	// RVA: 0xA7BFF0 Offset: 0xA7A9F0 VA: 0x180A7BFF0
	private static void TestStaticMethod() { }

	[Button("Space Before and After", Spacing = 3)]
	// RVA: 0xA7BEA0 Offset: 0xA7A8A0 VA: 0x180A7BEA0
	private void TestButtonSpaceBoth() { }

	[Button("Button With Parameters")]
	// RVA: 0xA7BF00 Offset: 0xA7A900 VA: 0x180A7BF00
	private void TestButtonWithParams(string message, int number) { }

	[Button("Expanded Button Example", Expanded = True)]
	// RVA: 0xA7BFA0 Offset: 0xA7A9A0 VA: 0x180A7BFA0
	private void TestExpandedButton(string message) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}

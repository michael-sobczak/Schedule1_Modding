public class BindingCompleteEventArgs : CancelEventArgs // TypeDefIndex: 5240
{
	// Fields
	private Binding binding; // 0x18
	private BindingCompleteState state; // 0x20
	private BindingCompleteContext context; // 0x24
	private string error_text; // 0x28
	private Exception exception; // 0x30

	// Methods

	// RVA: 0x21C39B0 Offset: 0x21C23B0 VA: 0x1821C39B0
	public void .ctor(Binding binding, BindingCompleteState state, BindingCompleteContext context) { }

	// RVA: 0x21C3930 Offset: 0x21C2330 VA: 0x1821C3930
	public void .ctor(Binding binding, BindingCompleteState state, BindingCompleteContext context, string errorText, Exception exception, bool cancel) { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void SetErrorText(string error_text) { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void SetException(Exception exception) { }
}

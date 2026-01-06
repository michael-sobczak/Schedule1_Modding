public class ProgressChangedEventArgs : EventArgs // TypeDefIndex: 9789
{
	// Fields
	private readonly int progressPercentage; // 0x10
	private readonly object userState; // 0x18

	// Properties
	[SRDescription("Percentage progress made in operation.")]
	public int ProgressPercentage { get; }
	[SRDescription("User-supplied state to identify operation.")]
	public object UserState { get; }

	// Methods

	// RVA: 0x266C6D0 Offset: 0x266B0D0 VA: 0x18266C6D0
	public void .ctor(int progressPercentage, object userState) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_ProgressPercentage() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public object get_UserState() { }
}

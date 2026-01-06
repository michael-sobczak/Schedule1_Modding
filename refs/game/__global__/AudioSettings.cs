public sealed class AudioSettings // TypeDefIndex: 18951
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemShuttingDown; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action OnAudioSystemStartedUp; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2C7C330 Offset: 0x2C7AD30 VA: 0x182C7C330
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x2C7C390 Offset: 0x2C7AD90 VA: 0x182C7C390
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	// RVA: 0x2C7C3E0 Offset: 0x2C7ADE0 VA: 0x182C7C3E0
	internal static void InvokeOnAudioSystemStartedUp() { }
}

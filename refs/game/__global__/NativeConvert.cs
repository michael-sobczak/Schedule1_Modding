public sealed class NativeConvert // TypeDefIndex: 19225
{
	// Fields
	public static readonly DateTime UnixEpoch; // 0x0
	public static readonly DateTime LocalUnixEpoch; // 0x8
	public static readonly TimeSpan LocalUtcOffset; // 0x10
	private static readonly string[][] fopen_modes; // 0x18

	// Methods

	// RVA: 0x1A50D90 Offset: 0x1A4F790 VA: 0x181A50D90
	private static void ThrowArgumentException(object value) { }

	// RVA: 0x1A50C00 Offset: 0x1A4F600 VA: 0x181A50C00
	private static extern int FromPollEvents(PollEvents value, out short rval) { }

	// RVA: 0x1A50C90 Offset: 0x1A4F690 VA: 0x181A50C90
	public static short FromPollEvents(PollEvents value) { }

	// RVA: 0x1A50E10 Offset: 0x1A4F810 VA: 0x181A50E10
	private static extern int ToPollEvents(short value, out PollEvents rval) { }

	// RVA: 0x1A50EA0 Offset: 0x1A4F8A0 VA: 0x181A50EA0
	public static PollEvents ToPollEvents(short value) { }

	// RVA: 0x1A50FA0 Offset: 0x1A4F9A0 VA: 0x181A50FA0
	private static void .cctor() { }
}

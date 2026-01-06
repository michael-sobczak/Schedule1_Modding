public struct OSPlatform : IEquatable<OSPlatform> // TypeDefIndex: 4521
{
	// Fields
	private readonly string _osPlatform; // 0x0
	[CompilerGenerated]
	private static readonly OSPlatform <Linux>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly OSPlatform <OSX>k__BackingField; // 0x8
	[CompilerGenerated]
	private static readonly OSPlatform <Windows>k__BackingField; // 0x10

	// Properties
	public static OSPlatform Linux { get; }
	public static OSPlatform OSX { get; }
	public static OSPlatform Windows { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B6A240 Offset: 0x1B68C40 VA: 0x181B6A240
	public static OSPlatform get_Linux() { }

	[CompilerGenerated]
	// RVA: 0x1B6A290 Offset: 0x1B68C90 VA: 0x181B6A290
	public static OSPlatform get_OSX() { }

	[CompilerGenerated]
	// RVA: 0x1B6A2E0 Offset: 0x1B68CE0 VA: 0x181B6A2E0
	public static OSPlatform get_Windows() { }

	// RVA: 0x1B6A170 Offset: 0x1B68B70 VA: 0x181B6A170
	private void .ctor(string osPlatform) { }

	// RVA: 0x1B69B70 Offset: 0x1B68570 VA: 0x181B69B70
	public static OSPlatform Create(string osPlatform) { }

	// RVA: 0x1B69C50 Offset: 0x1B68650 VA: 0x181B69C50 Slot: 4
	public bool Equals(OSPlatform other) { }

	// RVA: 0x1B69D90 Offset: 0x1B68790 VA: 0x181B69D90
	internal bool Equals(string other) { }

	// RVA: 0x1B69CB0 Offset: 0x1B686B0 VA: 0x181B69CB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B69DB0 Offset: 0x1B687B0 VA: 0x181B69DB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B69DD0 Offset: 0x1B687D0 VA: 0x181B69DD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B6A330 Offset: 0x1B68D30 VA: 0x181B6A330
	public static bool op_Equality(OSPlatform left, OSPlatform right) { }

	// RVA: 0x1B69E20 Offset: 0x1B68820 VA: 0x181B69E20
	private static void .cctor() { }
}

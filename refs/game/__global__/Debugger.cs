public sealed class Debugger // TypeDefIndex: 4870
{
	// Fields
	public static readonly string DefaultCategory; // 0x0

	// Methods

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80
	public static bool IsLogging() { }

	// RVA: 0x1B963C0 Offset: 0x1B94DC0 VA: 0x181B963C0
	private static void Log_icall(int level, ref string category, ref string message) { }

	// RVA: 0x1BF7FC0 Offset: 0x1BF69C0 VA: 0x181BF7FC0
	public static void Log(int level, string category, string message) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void NotifyOfCrossThreadDependency() { }

	// RVA: 0x1BF8020 Offset: 0x1BF6A20 VA: 0x181BF8020
	private static void .cctor() { }
}

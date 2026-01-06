internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 3903
{
	// Fields
	private IntPtr inputHandle; // 0x10
	private IntPtr outputHandle; // 0x18
	private short defaultAttribute; // 0x20

	// Methods

	// RVA: 0x1CEB2D0 Offset: 0x1CE9CD0 VA: 0x181CEB2D0
	public void .ctor() { }

	// RVA: 0x1CEB080 Offset: 0x1CE9A80 VA: 0x181CEB080 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1CEAF20 Offset: 0x1CE9920 VA: 0x181CEAF20
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x1CEAE90 Offset: 0x1CE9890 VA: 0x181CEAE90
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x1CEADF0 Offset: 0x1CE97F0 VA: 0x181CEADF0
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x1CEAF50 Offset: 0x1CE9950 VA: 0x181CEAF50
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }
}

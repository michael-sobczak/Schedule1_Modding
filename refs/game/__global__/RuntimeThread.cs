internal sealed class RuntimeThread // TypeDefIndex: 3554
{
	// Fields
	internal static readonly int OptimalMaxSpinWaitsPerSpinIteration; // 0x0
	private readonly Thread thread; // 0x10

	// Properties
	public bool IsBackground { set; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	private void .ctor(Thread t) { }

	// RVA: 0x1AA6060 Offset: 0x1AA4A60 VA: 0x181AA6060
	public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x1AA61A0 Offset: 0x1AA4BA0 VA: 0x181AA61A0
	public void set_IsBackground(bool value) { }

	// RVA: 0x1AA6130 Offset: 0x1AA4B30 VA: 0x181AA6130
	public void Start(object state) { }

	// RVA: 0x1AA6100 Offset: 0x1AA4B00 VA: 0x181AA6100
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x1AA6150 Offset: 0x1AA4B50 VA: 0x181AA6150
	public static bool Yield() { }

	// RVA: 0x1AA6110 Offset: 0x1AA4B10 VA: 0x181AA6110
	public static bool SpinWait(int iterations) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	public static int GetCurrentProcessorId() { }

	// RVA: 0x1AA6160 Offset: 0x1AA4B60 VA: 0x181AA6160
	private static void .cctor() { }
}

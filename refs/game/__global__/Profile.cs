public class Profile // TypeDefIndex: 13345
{
	// Fields
	private const bool PROFILE_MEM = False;
	public readonly string name; // 0x10
	private readonly Stopwatch watch; // 0x18
	private int counter; // 0x20
	private long mem; // 0x28
	private long smem; // 0x30
	private int control; // 0x38
	private const bool dontCountFirst = False;

	// Methods

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public int ControlValue() { }

	// RVA: 0xB8D280 Offset: 0xB8BC80 VA: 0x180B8D280
	public void .ctor(string name) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void WriteCSV(string path, Profile[] profiles) { }

	// RVA: 0xB8CEF0 Offset: 0xB8B8F0 VA: 0x180B8CEF0
	public void Run(Action action) { }

	[Conditional("PROFILE")]
	// RVA: 0xB8CF20 Offset: 0xB8B920 VA: 0x180B8CF20
	public void Start() { }

	[Conditional("PROFILE")]
	// RVA: 0xB8D030 Offset: 0xB8BA30 VA: 0x180B8D030
	public void Stop() { }

	[Conditional("PROFILE")]
	// RVA: 0xB8CE80 Offset: 0xB8B880 VA: 0x180B8CE80
	public void Log() { }

	[Conditional("PROFILE")]
	// RVA: 0xB8CC20 Offset: 0xB8B620 VA: 0x180B8CC20
	public void ConsoleLog() { }

	[Conditional("PROFILE")]
	// RVA: 0xB8CF40 Offset: 0xB8B940 VA: 0x180B8CF40
	public void Stop(int control) { }

	[Conditional("PROFILE")]
	// RVA: 0xB8CC90 Offset: 0xB8B690 VA: 0x180B8CC90
	public void Control(Profile other) { }

	// RVA: 0xB8D060 Offset: 0xB8BA60 VA: 0x180B8D060 Slot: 3
	public override string ToString() { }
}

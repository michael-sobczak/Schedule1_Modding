public class StackFrame // TypeDefIndex: 4871
{
	// Fields
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40

	// Methods

	// RVA: 0x1C04DA0 Offset: 0x1C037A0 VA: 0x181C04DA0
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0x1C04CD0 Offset: 0x1C036D0 VA: 0x181C04CD0
	public void .ctor() { }

	// RVA: 0x1C04D30 Offset: 0x1C03730 VA: 0x181C04D30
	public void .ctor(int skipFrames) { }

	// RVA: 0x1C04C50 Offset: 0x1C03650 VA: 0x181C04C50
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 5
	public virtual string GetFileName() { }

	// RVA: 0x1C049E0 Offset: 0x1C033E0 VA: 0x181C049E0
	internal string GetSecureFileName() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 6
	public virtual int GetILOffset() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 7
	public virtual MethodBase GetMethod() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70 Slot: 8
	public virtual int GetNativeOffset() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal long GetMethodAddress() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	internal uint GetMethodIndex() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal string GetInternalMethodName() { }

	// RVA: 0x1C04A40 Offset: 0x1C03440 VA: 0x181C04A40 Slot: 3
	public override string ToString() { }
}

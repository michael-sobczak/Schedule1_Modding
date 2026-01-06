public abstract class FileSystemInfo : MarshalByRefObject, ISerializable // TypeDefIndex: 5083
{
	// Fields
	private Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA _data; // 0x18
	private int _dataInitialized; // 0x3C
	protected string FullPath; // 0x40
	protected string OriginalPath; // 0x48
	internal string _name; // 0x50

	// Properties
	public FileAttributes Attributes { get; }
	internal bool ExistsCore { get; }
	internal DateTimeOffset LastAccessTimeCore { get; }
	internal long LengthCore { get; }
	internal string NormalizedPath { get; }
	public virtual string FullName { get; }
	public virtual string Name { get; }
	public virtual bool Exists { get; }
	public DateTime LastAccessTime { get; }
	public DateTime LastAccessTimeUtc { get; }

	// Methods

	// RVA: 0x1C29AA0 Offset: 0x1C284A0 VA: 0x181C29AA0
	protected void .ctor() { }

	// RVA: 0x1C2FD30 Offset: 0x1C2E730 VA: 0x181C2FD30
	internal static FileSystemInfo Create(string fullPath, ref FileSystemEntry findData) { }

	// RVA: 0x1C30460 Offset: 0x1C2EE60 VA: 0x181C30460
	internal void Init(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info) { }

	// RVA: 0x1C306B0 Offset: 0x1C2F0B0 VA: 0x181C306B0
	public FileAttributes get_Attributes() { }

	// RVA: 0x1C30720 Offset: 0x1C2F120 VA: 0x181C30720
	internal bool get_ExistsCore() { }

	// RVA: 0x1C30830 Offset: 0x1C2F230 VA: 0x181C30830
	internal DateTimeOffset get_LastAccessTimeCore() { }

	// RVA: 0x1C30AA0 Offset: 0x1C2F4A0 VA: 0x181C30AA0
	internal long get_LengthCore() { }

	// RVA: 0x1C302A0 Offset: 0x1C2ECA0 VA: 0x181C302A0
	private void EnsureDataInitialized() { }

	// RVA: 0x1C304B0 Offset: 0x1C2EEB0 VA: 0x181C304B0
	public void Refresh() { }

	// RVA: 0x1C30B20 Offset: 0x1C2F520 VA: 0x181C30B20
	internal string get_NormalizedPath() { }

	// RVA: 0x1C30530 Offset: 0x1C2EF30 VA: 0x181C30530
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	// RVA: 0x1C30310 Offset: 0x1C2ED10 VA: 0x181C30310 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 8
	public virtual string get_FullName() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x1C307A0 Offset: 0x1C2F1A0 VA: 0x181C307A0 Slot: 10
	public virtual bool get_Exists() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Delete();

	// RVA: 0x1C30990 Offset: 0x1C2F390 VA: 0x181C30990
	public DateTime get_LastAccessTime() { }

	// RVA: 0x1C308C0 Offset: 0x1C2F2C0 VA: 0x181C308C0
	public DateTime get_LastAccessTimeUtc() { }

	// RVA: 0x1C304E0 Offset: 0x1C2EEE0 VA: 0x181C304E0 Slot: 3
	public override string ToString() { }
}

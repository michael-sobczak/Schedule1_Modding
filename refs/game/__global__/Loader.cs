public class Loader // TypeDefIndex: 885
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public virtual void Load(string mainPath) { }

	// RVA: 0x5C25B0 Offset: 0x5C0FB0 VA: 0x1805C25B0
	public bool TryLoadFile(string parentPath, string fileName, out string contents) { }

	// RVA: 0x5C2640 Offset: 0x5C1040 VA: 0x1805C2640
	public bool TryLoadFile(string path, out string contents, bool autoAddExtension = True) { }

	// RVA: 0x5C2250 Offset: 0x5C0C50 VA: 0x1805C2250
	protected List<DirectoryInfo> GetDirectories(string parentPath) { }

	// RVA: 0x5C2400 Offset: 0x5C0E00 VA: 0x1805C2400
	protected List<FileInfo> GetFiles(string parenPath) { }

	// RVA: -1 Offset: -1
	public static bool TryDeserialize<T>(string json, out T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFCC80 Offset: 0xEFB680 VA: 0x180EFCC80
	|-Loader.TryDeserialize<object>
	|
	|-RVA: 0xEFCB00 Offset: 0xEFB500 VA: 0x180EFCB00
	|-Loader.TryDeserialize<__Il2CppFullySharedGenericType>
	*/
}

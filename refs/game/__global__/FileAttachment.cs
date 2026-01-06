public class FileAttachment // TypeDefIndex: 17995
{
	// Fields
	private string name; // 0x10
	private byte[] data; // 0x18
	private string mimeType; // 0x20

	// Properties
	public string Name { get; set; }
	public byte[] Data { get; set; }
	public string MimeType { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	// RVA: 0x43F000 Offset: 0x43DA00 VA: 0x18043F000
	public void set_Name(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public byte[] get_Data() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Data(byte[] value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_MimeType() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_MimeType(string value) { }

	// RVA: 0x43EE90 Offset: 0x43D890 VA: 0x18043EE90
	public void .ctor(string name, byte[] data, string mimeType) { }

	// RVA: 0x43EF00 Offset: 0x43D900 VA: 0x18043EF00
	public void .ctor(string filePath, string mimeType) { }

	// RVA: 0x43EE10 Offset: 0x43D810 VA: 0x18043EE10
	public void .ctor(string name, string filePath, string mimeType) { }
}

public class MailAddress // TypeDefIndex: 10223
{
	// Fields
	private readonly Encoding _displayNameEncoding; // 0x10
	private readonly string _displayName; // 0x18
	private readonly string _userName; // 0x20
	private readonly string _host; // 0x28
	private static readonly EncodedStreamFactory s_encoderFactory; // 0x0

	// Properties
	public string DisplayName { get; }
	public string Address { get; }
	private string SmtpAddress { get; }

	// Methods

	// RVA: 0x25DCB60 Offset: 0x25DB560 VA: 0x1825DCB60
	internal void .ctor(string displayName, string userName, string domain) { }

	// RVA: 0x25DCB40 Offset: 0x25DB540 VA: 0x1825DCB40
	public void .ctor(string address) { }

	// RVA: 0x25DC870 Offset: 0x25DB270 VA: 0x1825DC870
	public void .ctor(string address, string displayName, Encoding displayNameEncoding) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_DisplayName() { }

	// RVA: 0x25DCC10 Offset: 0x25DB610 VA: 0x1825DCC10
	public string get_Address() { }

	// RVA: 0x25DCC60 Offset: 0x25DB660 VA: 0x1825DCC60
	private string get_SmtpAddress() { }

	// RVA: 0x25DC6C0 Offset: 0x25DB0C0 VA: 0x1825DC6C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x25DC600 Offset: 0x25DB000 VA: 0x1825DC600 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x25DC680 Offset: 0x25DB080 VA: 0x1825DC680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x25DC7F0 Offset: 0x25DB1F0 VA: 0x1825DC7F0
	private static void .cctor() { }
}

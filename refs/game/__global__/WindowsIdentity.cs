public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 4262
{
	// Fields
	private IntPtr _token; // 0x78
	private string _type; // 0x80
	private WindowsAccountType _account; // 0x88
	private bool _authenticated; // 0x8C
	private string _name; // 0x90
	private SerializationInfo _info; // 0x98
	private static IntPtr invalidWindows; // 0x0

	// Properties
	public sealed override string AuthenticationType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x1B20580 Offset: 0x1B1EF80 VA: 0x181B20580
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x1B20770 Offset: 0x1B1F170 VA: 0x181B20770
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	// RVA: 0x1B1FC10 Offset: 0x1B1E610 VA: 0x181B1FC10 Slot: 14
	public void Dispose() { }

	// RVA: 0x1B1FC30 Offset: 0x1B1E630 VA: 0x181B1FC30
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x1B1FE70 Offset: 0x1B1E870 VA: 0x181B1FE70 Slot: 15
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400 Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x1B207D0 Offset: 0x1B1F1D0 VA: 0x181B207D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B200A0 Offset: 0x1B1EAA0 VA: 0x181B200A0 Slot: 12
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1B20400 Offset: 0x1B1EE00 VA: 0x181B20400 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B1FF30 Offset: 0x1B1E930 VA: 0x181B1FF30
	private void SetToken(IntPtr token) { }

	// RVA: 0x1B1FC20 Offset: 0x1B1E620 VA: 0x181B1FC20
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x1B1FE60 Offset: 0x1B1E860 VA: 0x181B1FE60
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x1B20540 Offset: 0x1B1EF40 VA: 0x181B20540
	private static void .cctor() { }
}

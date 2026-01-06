public class ValidationResult // TypeDefIndex: 17533
{
	// Fields
	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; // 0x18

	// Properties
	public bool Trusted { get; }
	public bool UserDenied { get; }

	// Methods

	// RVA: 0x1A825F0 Offset: 0x1A80FF0 VA: 0x181A825F0
	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_Trusted() { }

	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	public bool get_UserDenied() { }
}

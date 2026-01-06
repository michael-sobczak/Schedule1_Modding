internal class ResponseDescription // TypeDefIndex: 9941
{
	// Fields
	internal bool Multiline; // 0x10
	internal int Status; // 0x14
	internal string StatusDescription; // 0x18
	internal StringBuilder StatusBuffer; // 0x20
	internal string StatusCodeString; // 0x28

	// Properties
	internal bool PositiveIntermediate { get; }
	internal bool PositiveCompletion { get; }
	internal bool TransientFailure { get; }
	internal bool PermanentFailure { get; }
	internal bool InvalidStatusCode { get; }

	// Methods

	// RVA: 0x26B49C0 Offset: 0x26B33C0 VA: 0x1826B49C0
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x26B49A0 Offset: 0x26B33A0 VA: 0x1826B49A0
	internal bool get_PositiveCompletion() { }

	// RVA: 0x26B49E0 Offset: 0x26B33E0 VA: 0x1826B49E0
	internal bool get_TransientFailure() { }

	// RVA: 0x26B4980 Offset: 0x26B3380 VA: 0x1826B4980
	internal bool get_PermanentFailure() { }

	// RVA: 0x26B4960 Offset: 0x26B3360 VA: 0x1826B4960
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x26B48F0 Offset: 0x26B32F0 VA: 0x1826B48F0
	public void .ctor() { }
}

internal struct DateTimeResult // TypeDefIndex: 3648
{
	// Fields
	internal int Year; // 0x0
	internal int Month; // 0x4
	internal int Day; // 0x8
	internal int Hour; // 0xC
	internal int Minute; // 0x10
	internal int Second; // 0x14
	internal double fraction; // 0x18
	internal int era; // 0x20
	internal ParseFlags flags; // 0x24
	internal TimeSpan timeZoneOffset; // 0x28
	internal Calendar calendar; // 0x30
	internal DateTime parsedDate; // 0x38
	internal ParseFailureKind failure; // 0x40
	internal string failureMessageID; // 0x48
	internal object failureMessageFormatArgument; // 0x50
	internal string failureArgumentName; // 0x58
	internal ReadOnlySpan<char> originalDateTimeString; // 0x60
	internal ReadOnlySpan<char> failedFormatSpecifier; // 0x70

	// Methods

	// RVA: 0x1C5FC70 Offset: 0x1C5E670 VA: 0x181C5FC70
	internal void Init(ReadOnlySpan<char> originalDateTimeString) { }

	// RVA: 0x527620 Offset: 0x526020 VA: 0x180527620
	internal void SetDate(int year, int month, int day) { }

	// RVA: 0x1C5FD40 Offset: 0x1C5E740 VA: 0x181C5FD40
	internal void SetBadFormatSpecifierFailure() { }

	// RVA: 0x1C5FCF0 Offset: 0x1C5E6F0 VA: 0x181C5FCF0
	internal void SetBadFormatSpecifierFailure(ReadOnlySpan<char> failedFormatSpecifier) { }

	// RVA: 0x1C5FCA0 Offset: 0x1C5E6A0 VA: 0x181C5FCA0
	internal void SetBadDateTimeFailure() { }

	// RVA: 0x1C5FDF0 Offset: 0x1C5E7F0 VA: 0x181C5FDF0
	internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x1C5FDC0 Offset: 0x1C5E7C0 VA: 0x181C5FDC0
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1C5FDD0 Offset: 0x1C5E7D0 VA: 0x181C5FDD0
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }
}

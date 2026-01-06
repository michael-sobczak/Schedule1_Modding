internal sealed class NetEventSource : EventSource // TypeDefIndex: 9928
{
	// Fields
	public static readonly NetEventSource Log; // 0x0

	// Properties
	public static bool IsEnabled { get; }

	// Methods

	[NonEvent]
	// RVA: 0x26AF850 Offset: 0x26AE250 VA: 0x1826AF850
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x26AF6D0 Offset: 0x26AE0D0 VA: 0x1826AF6D0
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	[NonEvent]
	// RVA: 0x26AF9E0 Offset: 0x26AE3E0 VA: 0x1826AF9E0
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	[Event(1, Level = 4, Keywords = 4)]
	// RVA: 0x26AFB90 Offset: 0x26AE590 VA: 0x1826AFB90
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	[NonEvent]
	// RVA: 0x26AFEB0 Offset: 0x26AE8B0 VA: 0x1826AFEB0
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x26B0040 Offset: 0x26AEA40 VA: 0x1826B0040
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	[Event(2, Level = 4, Keywords = 4)]
	// RVA: 0x26AFE20 Offset: 0x26AE820 VA: 0x1826AFE20
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	[NonEvent]
	// RVA: 0x26B0BD0 Offset: 0x26AF5D0 VA: 0x1826B0BD0
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x26B0DF0 Offset: 0x26AF7F0 VA: 0x1826B0DF0
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	[Event(4, Level = 4, Keywords = 1)]
	// RVA: 0x26B0D60 Offset: 0x26AF760 VA: 0x1826B0D60
	private void Info(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x26AFCB0 Offset: 0x26AE6B0 VA: 0x1826AFCB0
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	[Event(5, Level = 3, Keywords = 1)]
	// RVA: 0x26AFC20 Offset: 0x26AE620 VA: 0x1826AFC20
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x26B01B0 Offset: 0x26AEBB0 VA: 0x1826B01B0
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	[Event(6, Level = 1, Keywords = 2)]
	// RVA: 0x26AF640 Offset: 0x26AE040 VA: 0x1826AF640
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x26AF420 Offset: 0x26ADE20 VA: 0x1826AF420
	public static void Associate(object first, object second, string memberName) { }

	[Event(3, Level = 4, Keywords = 1, Message = "[{2}]<-->[{3}]")]
	// RVA: 0x26AF5A0 Offset: 0x26ADFA0 VA: 0x1826AF5A0
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x26B11D0 Offset: 0x26AFBD0 VA: 0x1826B11D0
	public static bool get_IsEnabled() { }

	[NonEvent]
	// RVA: 0x26B0AE0 Offset: 0x26AF4E0 VA: 0x1826B0AE0
	public static string IdOf(object value) { }

	[NonEvent]
	// RVA: 0x26B0AC0 Offset: 0x26AF4C0 VA: 0x1826B0AC0
	public static int GetHashCode(object value) { }

	[NonEvent]
	// RVA: 0x26B06C0 Offset: 0x26AF0C0 VA: 0x1826B06C0
	public static object Format(object value) { }

	[NonEvent]
	// RVA: 0x26B0320 Offset: 0x26AED20 VA: 0x1826B0320
	private static string Format(FormattableString s) { }

	[NonEvent]
	// RVA: 0x26B0F60 Offset: 0x26AF960 VA: 0x1826B0F60
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x1C0B270 Offset: 0x1C09C70 VA: 0x181C0B270
	public void .ctor() { }

	// RVA: 0x26B1160 Offset: 0x26AFB60 VA: 0x1826B1160
	private static void .cctor() { }
}

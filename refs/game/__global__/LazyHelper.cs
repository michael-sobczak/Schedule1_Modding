internal class LazyHelper // TypeDefIndex: 3680
{
	// Fields
	internal static readonly LazyHelper NoneViaConstructor; // 0x0
	internal static readonly LazyHelper NoneViaFactory; // 0x8
	internal static readonly LazyHelper PublicationOnlyViaConstructor; // 0x10
	internal static readonly LazyHelper PublicationOnlyViaFactory; // 0x18
	internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish; // 0x20
	[CompilerGenerated]
	private readonly LazyState <State>k__BackingField; // 0x10
	private readonly ExceptionDispatchInfo _exceptionDispatch; // 0x18

	// Properties
	internal LazyState State { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	internal LazyState get_State() { }

	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	internal void .ctor(LazyState state) { }

	// RVA: 0x1C67990 Offset: 0x1C66390 VA: 0x181C67990
	internal void .ctor(LazyThreadSafetyMode mode, Exception exception) { }

	// RVA: 0x1C677D0 Offset: 0x1C661D0 VA: 0x181C677D0
	internal void ThrowException() { }

	// RVA: 0x1C67630 Offset: 0x1C66030 VA: 0x181C67630
	internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	// RVA: 0x1C675C0 Offset: 0x1C65FC0 VA: 0x181C675C0
	internal static object CreateViaDefaultConstructor(Type type) { }

	// RVA: 0x1C677F0 Offset: 0x1C661F0 VA: 0x181C677F0
	private static void .cctor() { }
}

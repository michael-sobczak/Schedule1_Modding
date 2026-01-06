public struct CancellationToken // TypeDefIndex: 3933
{
	// Fields
	private readonly CancellationTokenSource _source; // 0x0
	private static readonly Action<object> s_actionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }

	// Methods

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public static CancellationToken get_None() { }

	// RVA: 0x1CD57F0 Offset: 0x1CD41F0 VA: 0x181CD57F0
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1CD57E0 Offset: 0x1CD41E0 VA: 0x181CD57E0
	public bool get_CanBeCanceled() { }

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x1CD5740 Offset: 0x1CD4140 VA: 0x181CD5740
	public void .ctor(bool canceled) { }

	// RVA: 0x1CD51C0 Offset: 0x1CD3BC0 VA: 0x181CD51C0
	public CancellationTokenRegistration Register(Action callback) { }

	// RVA: 0x1CD52D0 Offset: 0x1CD3CD0 VA: 0x181CD52D0
	public CancellationTokenRegistration Register(Action<object> callback, object state) { }

	// RVA: 0x1CD54E0 Offset: 0x1CD3EE0 VA: 0x181CD54E0
	public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext) { }

	// RVA: 0x1CD5110 Offset: 0x1CD3B10 VA: 0x181CD5110
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x1CD5380 Offset: 0x1CD3D80 VA: 0x181CD5380
	public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0
	public bool Equals(CancellationToken other) { }

	// RVA: 0x1CD4FF0 Offset: 0x1CD39F0 VA: 0x181CD4FF0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1CD5090 Offset: 0x1CD3A90 VA: 0x181CD5090 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CD5830 Offset: 0x1CD4230 VA: 0x181CD5830
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x1CD5890 Offset: 0x1CD4290 VA: 0x181CD5890
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x1CD5590 Offset: 0x1CD3F90 VA: 0x181CD5590
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x1CD5610 Offset: 0x1CD4010 VA: 0x181CD5610
	private void ThrowOperationCanceledException() { }

	// RVA: 0x1CD5670 Offset: 0x1CD4070 VA: 0x181CD5670
	private static void .cctor() { }
}

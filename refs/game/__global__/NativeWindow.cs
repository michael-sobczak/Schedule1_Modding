public class NativeWindow : MarshalByRefObject, IWin32Window // TypeDefIndex: 5520
{
	// Fields
	private IntPtr window_handle; // 0x18
	private static Hashtable window_collection; // 0x0
	[ThreadStatic]
	private static NativeWindow WindowCreating; // 0x80000000

	// Properties
	public IntPtr Handle { get; }

	// Methods

	// RVA: 0x239A420 Offset: 0x2398E20 VA: 0x18239A420
	public void .ctor() { }

	// RVA: 0x239A3A0 Offset: 0x2398DA0 VA: 0x18239A3A0
	private static void .cctor() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 6
	public IntPtr get_Handle() { }

	// RVA: 0x2399770 Offset: 0x2398170 VA: 0x182399770
	public static NativeWindow FromHandle(IntPtr handle) { }

	// RVA: 0x23997C0 Offset: 0x23981C0 VA: 0x1823997C0
	internal void InvalidateHandle() { }

	// RVA: 0x23991A0 Offset: 0x2397BA0 VA: 0x1823991A0
	public void AssignHandle(IntPtr handle) { }

	// RVA: 0x2398DF0 Offset: 0x23977F0 VA: 0x182398DF0
	private static void AddToTable(NativeWindow window) { }

	// RVA: 0x2399870 Offset: 0x2398270 VA: 0x182399870
	private static void RemoveFromTable(NativeWindow window) { }

	// RVA: 0x2399530 Offset: 0x2397F30 VA: 0x182399530
	private static NativeWindow FindFirstInTable(IntPtr handle) { }

	// RVA: 0x2399220 Offset: 0x2397C20 VA: 0x182399220 Slot: 7
	public virtual void CreateHandle(CreateParams cp) { }

	// RVA: 0x2399330 Offset: 0x2397D30 VA: 0x182399330
	public void DefWndProc(ref Message m) { }

	// RVA: 0x2399380 Offset: 0x2397D80 VA: 0x182399380 Slot: 8
	public virtual void DestroyHandle() { }

	// RVA: 0x1B60510 Offset: 0x1B5EF10 VA: 0x181B60510 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	protected virtual void OnHandleChange() { }

	// RVA: 0x2399820 Offset: 0x2398220 VA: 0x182399820 Slot: 10
	protected virtual void OnThreadException(Exception e) { }

	// RVA: 0x2399330 Offset: 0x2397D30 VA: 0x182399330 Slot: 11
	protected virtual void WndProc(ref Message m) { }

	// RVA: 0x2399C40 Offset: 0x2398640 VA: 0x182399C40
	internal static IntPtr WndProc(IntPtr hWnd, Msg msg, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x23993F0 Offset: 0x2397DF0 VA: 0x1823993F0
	private static NativeWindow EnsureCreated(NativeWindow window, IntPtr hWnd) { }
}

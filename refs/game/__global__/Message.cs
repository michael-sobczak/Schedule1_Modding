public struct Message // TypeDefIndex: 5497
{
	// Fields
	private int msg; // 0x0
	private IntPtr hwnd; // 0x8
	private IntPtr lParam; // 0x10
	private IntPtr wParam; // 0x18
	private IntPtr result; // 0x20

	// Properties
	public IntPtr HWnd { get; set; }
	public IntPtr LParam { get; set; }
	public int Msg { get; set; }
	public IntPtr Result { get; set; }
	public IntPtr WParam { get; set; }

	// Methods

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public IntPtr get_HWnd() { }

	// RVA: 0x1CD2E00 Offset: 0x1CD1800 VA: 0x181CD2E00
	public void set_HWnd(IntPtr value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public IntPtr get_LParam() { }

	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	public void set_LParam(IntPtr value) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_Msg() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_Msg(int value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IntPtr get_Result() { }

	// RVA: 0x4F58D0 Offset: 0x4F42D0 VA: 0x1804F58D0
	public void set_Result(IntPtr value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IntPtr get_WParam() { }

	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void set_WParam(IntPtr value) { }

	// RVA: 0x23935B0 Offset: 0x2391FB0 VA: 0x1823935B0
	public static Message Create(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam) { }

	// RVA: 0x23935E0 Offset: 0x2391FE0 VA: 0x1823935E0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x23937C0 Offset: 0x23921C0 VA: 0x1823937C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2393830 Offset: 0x2392230 VA: 0x182393830 Slot: 3
	public override string ToString() { }
}

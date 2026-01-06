internal class MonoBtlsBioMono : MonoBtlsBio // TypeDefIndex: 9427
{
	// Fields
	private GCHandle handle; // 0x20
	private IntPtr instance; // 0x28
	private MonoBtlsBioMono.BioReadFunc readFunc; // 0x30
	private MonoBtlsBioMono.BioWriteFunc writeFunc; // 0x38
	private MonoBtlsBioMono.BioControlFunc controlFunc; // 0x40
	private IntPtr readFuncPtr; // 0x48
	private IntPtr writeFuncPtr; // 0x50
	private IntPtr controlFuncPtr; // 0x58
	private IMonoBtlsBioMono backend; // 0x60

	// Methods

	// RVA: 0x2014830 Offset: 0x2013230 VA: 0x182014830
	public void .ctor(IMonoBtlsBioMono backend) { }

	// RVA: 0x2014D60 Offset: 0x2013760 VA: 0x182014D60
	private static extern IntPtr mono_btls_bio_mono_new() { }

	// RVA: 0x2014CA0 Offset: 0x20136A0 VA: 0x182014CA0
	private static extern void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc) { }

	// RVA: 0x2014070 Offset: 0x2012A70 VA: 0x182014070
	private long Control(MonoBtlsBioMono.ControlCommand command, long arg) { }

	// RVA: 0x2014360 Offset: 0x2012D60 VA: 0x182014360
	private int OnRead(IntPtr data, int dataLength, out int wantMore) { }

	[MonoPInvokeCallback(typeof(MonoBtlsBioMono.BioReadFunc))]
	// RVA: 0x2014110 Offset: 0x2012B10 VA: 0x182014110
	private static int OnRead(IntPtr instance, IntPtr data, int dataLength, out int wantMore) { }

	// RVA: 0x20144D0 Offset: 0x2012ED0 VA: 0x1820144D0
	private int OnWrite(IntPtr data, int dataLength) { }

	[MonoPInvokeCallback(typeof(MonoBtlsBioMono.BioWriteFunc))]
	// RVA: 0x2014620 Offset: 0x2013020 VA: 0x182014620
	private static int OnWrite(IntPtr instance, IntPtr data, int dataLength) { }

	[MonoPInvokeCallback(typeof(MonoBtlsBioMono.BioControlFunc))]
	// RVA: 0x2013F10 Offset: 0x2012910 VA: 0x182013F10
	private static long Control(IntPtr instance, MonoBtlsBioMono.ControlCommand command, long arg) { }

	// RVA: 0x2013E50 Offset: 0x2012850 VA: 0x182013E50 Slot: 5
	protected override void Close() { }
}

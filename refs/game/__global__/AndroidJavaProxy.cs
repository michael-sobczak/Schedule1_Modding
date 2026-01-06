public class AndroidJavaProxy // TypeDefIndex: 18334
{
	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x2C6C560 Offset: 0x2C6AF60 VA: 0x182C6C560
	public void .ctor(string javaInterface) { }

	// RVA: 0x2C6C5E0 Offset: 0x2C6AFE0 VA: 0x182C6C5E0
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x2C6B370 Offset: 0x2C69D70 VA: 0x182C6B370 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2C6B510 Offset: 0x2C69F10 VA: 0x182C6B510 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x2C6BEE0 Offset: 0x2C6A8E0 VA: 0x182C6BEE0 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x2C6C080 Offset: 0x2C6AA80 VA: 0x182C6C080 Slot: 6
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x2C6C620 Offset: 0x2C6B020 VA: 0x182C6C620 Slot: 7
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x2C6C680 Offset: 0x2C6B080 VA: 0x182C6C680 Slot: 8
	public virtual int hashCode() { }

	// RVA: 0x2C6C760 Offset: 0x2C6B160 VA: 0x182C6C760 Slot: 9
	public virtual string toString() { }

	// RVA: 0x2C6B400 Offset: 0x2C69E00 VA: 0x182C6B400
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x2C6B420 Offset: 0x2C69E20 VA: 0x182C6B420
	internal IntPtr GetRawProxy() { }

	// RVA: 0x2C6C450 Offset: 0x2C6AE50 VA: 0x182C6C450
	private static void .cctor() { }
}

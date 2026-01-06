public sealed class CombineCallback : MulticastDelegate // TypeDefIndex: 10805
{
	// Methods

	// RVA: 0x540C10 Offset: 0x53F610 VA: 0x180540C10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x540BD0 Offset: 0x53F5D0 VA: 0x180540BD0 Slot: 13
	public virtual object Invoke(Vec3 position, object[] data, float[] weights) { }

	// RVA: 0x540B40 Offset: 0x53F540 VA: 0x180540B40 Slot: 14
	public virtual IAsyncResult BeginInvoke(Vec3 position, object[] data, float[] weights, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}

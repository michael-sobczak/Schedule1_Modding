public sealed class EventHandler<TEventArgs> : MulticastDelegate // TypeDefIndex: 3627
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD500 Offset: 0x17ABF00 VA: 0x1817AD500
	|-EventHandler<object>..ctor
	|
	|-RVA: 0x17AD3E0 Offset: 0x17ABDE0 VA: 0x1817AD3E0
	|-EventHandler<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(object sender, TEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0
	|-EventHandler<object>.Invoke
	|-EventHandler<__Il2CppFullySharedGenericType>.Invoke
	*/
}

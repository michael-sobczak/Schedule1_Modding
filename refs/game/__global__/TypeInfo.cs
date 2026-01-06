public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 4736
{
	// Fields
	private const BindingFlags DeclaredOnlyLookup = 62;

	// Properties
	public virtual IEnumerable<Type> ImplementedInterfaces { get; }

	// Methods

	// RVA: 0x1B9C9D0 Offset: 0x1B9B3D0 VA: 0x181B9C9D0
	protected void .ctor() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 132
	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	// RVA: 0x1B9CA20 Offset: 0x1B9B420 VA: 0x181B9CA20 Slot: 133
	public virtual IEnumerable<Type> get_ImplementedInterfaces() { }
}

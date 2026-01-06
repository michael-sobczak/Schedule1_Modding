internal abstract class SignatureHasElementType : SignatureType // TypeDefIndex: 4726
{
	// Fields
	private readonly SignatureType _elementType; // 0x18

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }
	protected abstract string Suffix { get; }

	// Methods

	// RVA: 0x1B98EC0 Offset: 0x1B978C0 VA: 0x181B98EC0
	protected void .ctor(SignatureType elementType) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 41
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 45
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract override bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract override bool IsPointerImpl();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsVariableBoundArray();

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 37
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 38
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 39
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x1B99660 Offset: 0x1B98060 VA: 0x181B99660 Slot: 20
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 132
	internal sealed override SignatureType get_ElementType() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract override int GetArrayRank();

	// RVA: 0x1B995A0 Offset: 0x1B97FA0 VA: 0x181B995A0 Slot: 48
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x1B99570 Offset: 0x1B97F70 VA: 0x181B99570 Slot: 50
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x1B996E0 Offset: 0x1B980E0 VA: 0x181B996E0 Slot: 49
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x1B99690 Offset: 0x1B98090 VA: 0x181B99690 Slot: 51
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x1B99710 Offset: 0x1B98110 VA: 0x181B99710 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x1B99540 Offset: 0x1B97F40 VA: 0x181B99540 Slot: 24
	public sealed override string get_Namespace() { }

	// RVA: 0x1B995F0 Offset: 0x1B97FF0 VA: 0x181B995F0 Slot: 3
	public sealed override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 133
	protected abstract string get_Suffix();
}

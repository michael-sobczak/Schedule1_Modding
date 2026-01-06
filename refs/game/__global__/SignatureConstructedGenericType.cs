internal sealed class SignatureConstructedGenericType : SignatureType // TypeDefIndex: 4725
{
	// Fields
	private readonly Type _genericTypeDefinition; // 0x18
	private readonly Type[] _genericTypeArguments; // 0x20

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }

	// Methods

	// RVA: 0x1B99130 Offset: 0x1B97B30 VA: 0x181B99130
	internal void .ctor(Type genericTypeDefinition, Type[] typeArguments) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 41
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 45
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 37
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 38
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 39
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x1B993A0 Offset: 0x1B97DA0 VA: 0x181B993A0 Slot: 20
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 132
	internal sealed override SignatureType get_ElementType() { }

	// RVA: 0x1B98F60 Offset: 0x1B97960 VA: 0x181B98F60 Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 48
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x1B98FB0 Offset: 0x1B979B0 VA: 0x181B98FB0 Slot: 50
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x1B99490 Offset: 0x1B97E90 VA: 0x181B99490 Slot: 49
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x1B99440 Offset: 0x1B97E40 VA: 0x181B99440 Slot: 51
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x1B99510 Offset: 0x1B97F10 VA: 0x181B99510 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x1B99540 Offset: 0x1B97F40 VA: 0x181B99540 Slot: 24
	public sealed override string get_Namespace() { }

	// RVA: 0x1B98FD0 Offset: 0x1B979D0 VA: 0x181B98FD0 Slot: 3
	public sealed override string ToString() { }
}

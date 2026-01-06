internal sealed class SignatureArrayType : SignatureHasElementType // TypeDefIndex: 4723
{
	// Fields
	private readonly int _rank; // 0x20
	private readonly bool _isMultiDim; // 0x24

	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x1B98D20 Offset: 0x1B97720 VA: 0x181B98D20
	internal void .ctor(SignatureType elementType, int rank, bool isMultiDim) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x1B98DB0 Offset: 0x1B977B0 VA: 0x181B98DB0 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x1B98DC0 Offset: 0x1B977C0 VA: 0x181B98DC0 Slot: 133
	protected sealed override string get_Suffix() { }
}

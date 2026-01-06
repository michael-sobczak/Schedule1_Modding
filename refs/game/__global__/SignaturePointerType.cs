internal sealed class SignaturePointerType : SignatureHasElementType // TypeDefIndex: 4727
{
	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x1B98EC0 Offset: 0x1B978C0 VA: 0x181B98EC0
	internal void .ctor(SignatureType elementType) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x1B99780 Offset: 0x1B98180 VA: 0x181B99780 Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x1B997D0 Offset: 0x1B981D0 VA: 0x181B997D0 Slot: 133
	protected sealed override string get_Suffix() { }
}

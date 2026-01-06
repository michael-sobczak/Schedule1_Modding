internal sealed class ExceptionHandler // TypeDefIndex: 15409
{
	// Fields
	private readonly Type _exceptionType; // 0x10
	public readonly int LabelIndex; // 0x18
	public readonly int HandlerStartIndex; // 0x1C
	public readonly int HandlerEndIndex; // 0x20
	public readonly ExceptionFilter Filter; // 0x28

	// Methods

	// RVA: 0x1FC0D20 Offset: 0x1FBF720 VA: 0x181FC0D20
	internal void .ctor(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	// RVA: 0x456EA0 Offset: 0x4558A0 VA: 0x180456EA0
	public bool Matches(Type exceptionType) { }

	// RVA: 0x1FC0C20 Offset: 0x1FBF620 VA: 0x181FC0C20 Slot: 3
	public override string ToString() { }
}

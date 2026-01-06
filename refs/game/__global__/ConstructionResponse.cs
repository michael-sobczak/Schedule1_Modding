public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 4379
{
	// Properties
	public override IDictionary Properties { get; }

	// Methods

	// RVA: 0x1B2CC90 Offset: 0x1B2B690 VA: 0x181B2CC90
	internal void .ctor(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x1B2CD50 Offset: 0x1B2B750 VA: 0x181B2CD50
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x1B2CD60 Offset: 0x1B2B760 VA: 0x181B2CD60
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B2CE00 Offset: 0x1B2B800 VA: 0x181B2CE00 Slot: 22
	public override IDictionary get_Properties() { }
}

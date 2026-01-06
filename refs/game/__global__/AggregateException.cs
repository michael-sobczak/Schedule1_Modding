public class AggregateException : Exception // TypeDefIndex: 3590
{
	// Fields
	private ReadOnlyCollection<Exception> m_innerExceptions; // 0x90

	// Properties
	public ReadOnlyCollection<Exception> InnerExceptions { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1BBA9E0 Offset: 0x1BB93E0 VA: 0x181BBA9E0
	public void .ctor() { }

	// RVA: 0x1BBA1C0 Offset: 0x1BB8BC0 VA: 0x181BBA1C0
	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x1BBA990 Offset: 0x1BB9390 VA: 0x181BBA990
	public void .ctor(Exception[] innerExceptions) { }

	// RVA: 0x1BBA370 Offset: 0x1BB8D70 VA: 0x181BBA370
	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x1BBA2A0 Offset: 0x1BB8CA0 VA: 0x181BBA2A0
	public void .ctor(string message, Exception[] innerExceptions) { }

	// RVA: 0x1BBA430 Offset: 0x1BB8E30 VA: 0x181BBA430
	private void .ctor(string message, IList<Exception> innerExceptions) { }

	// RVA: 0x1BBA6C0 Offset: 0x1BB90C0 VA: 0x181BBA6C0
	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1BBA2B0 Offset: 0x1BB8CB0 VA: 0x181BBA2B0
	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1BB9F10 Offset: 0x1BB8910 VA: 0x181BB9F10
	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1BBA7A0 Offset: 0x1BB91A0 VA: 0x181BBA7A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BB9BB0 Offset: 0x1BB85B0 VA: 0x181BB9BB0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	// RVA: 0x1BB9920 Offset: 0x1BB8320 VA: 0x181BB9920
	public AggregateException Flatten() { }

	// RVA: 0x1BBAAC0 Offset: 0x1BB94C0 VA: 0x181BBAAC0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1BB9CF0 Offset: 0x1BB86F0 VA: 0x181BB9CF0 Slot: 3
	public override string ToString() { }
}

internal abstract class JsonSerializerInternalBase // TypeDefIndex: 11256
{
	// Fields
	[Nullable(2)]
	private ErrorContext _currentErrorContext; // 0x10
	[Nullable(new[] { 2, 1, 1 })]
	private BidirectionalDictionary<string, object> _mappings; // 0x18
	internal readonly JsonSerializer Serializer; // 0x20
	[Nullable(2)]
	internal readonly ITraceWriter TraceWriter; // 0x28
	[Nullable(2)]
	protected JsonSerializerProxy InternalSerializer; // 0x30

	// Properties
	internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; }

	// Methods

	// RVA: 0x1D86830 Offset: 0x1D85230 VA: 0x181D86830
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0x1D86900 Offset: 0x1D85300 VA: 0x181D86900
	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	// RVA: 0x1D86790 Offset: 0x1D85190 VA: 0x181D86790
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0x1D86210 Offset: 0x1D84C10 VA: 0x181D86210
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0x1D86190 Offset: 0x1D84B90 VA: 0x181D86190
	protected void ClearErrorContext() { }

	[NullableContext(2)]
	// RVA: 0x1D86350 Offset: 0x1D84D50 VA: 0x181D86350
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }
}

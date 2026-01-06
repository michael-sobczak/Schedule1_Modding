public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 11254
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly List<JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0x1D85B70 Offset: 0x1D84570 VA: 0x181D85B70
	public void .ctor(Type type) { }

	// RVA: 0x1D85890 Offset: 0x1D84290 VA: 0x181D85890 Slot: 39
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0x1D85540 Offset: 0x1D83F40 VA: 0x181D85540
	public void AddProperty(JsonProperty property) { }

	// RVA: 0x1D85840 Offset: 0x1D84240 VA: 0x181D85840
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0x1D85A70 Offset: 0x1D84470 VA: 0x181D85A70
	private bool TryGetProperty(string key, out JsonProperty item) { }

	// RVA: 0x1D858B0 Offset: 0x1D842B0 VA: 0x181D858B0
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }
}

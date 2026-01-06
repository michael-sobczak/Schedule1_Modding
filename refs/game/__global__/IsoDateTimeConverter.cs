public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 11402
{
	// Fields
	private const string DefaultDateTimeFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK";
	private DateTimeStyles _dateTimeStyles; // 0x10
	[Nullable(2)]
	private string _dateTimeFormat; // 0x18
	[Nullable(2)]
	private CultureInfo _culture; // 0x20

	// Properties
	public DateTimeStyles DateTimeStyles { get; set; }
	[Nullable(2)]
	public string DateTimeFormat { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_DateTimeStyles(DateTimeStyles value) { }

	[NullableContext(2)]
	// RVA: 0x1DD7E90 Offset: 0x1DD6890 VA: 0x181DD7E90
	public string get_DateTimeFormat() { }

	[NullableContext(2)]
	// RVA: 0x1DD7EE0 Offset: 0x1DD68E0 VA: 0x181DD7EE0
	public void set_DateTimeFormat(string value) { }

	// RVA: 0x1DD7E30 Offset: 0x1DD6830 VA: 0x181DD7E30
	public CultureInfo get_Culture() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x1DD7AF0 Offset: 0x1DD64F0 VA: 0x181DD7AF0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DD7530 Offset: 0x1DD5F30 VA: 0x181DD7530 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DD7E20 Offset: 0x1DD6820 VA: 0x181DD7E20
	public void .ctor() { }
}

public class UnixDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 11407
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0
	[CompilerGenerated]
	private bool <AllowPreEpoch>k__BackingField; // 0x10

	// Properties
	public bool AllowPreEpoch { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_AllowPreEpoch() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	public void set_AllowPreEpoch(bool value) { }

	// RVA: 0x1DF28F0 Offset: 0x1DF12F0 VA: 0x181DF28F0
	public void .ctor() { }

	// RVA: 0xC19D80 Offset: 0xC18780 VA: 0x180C19D80
	public void .ctor(bool allowPreEpoch) { }

	// RVA: 0x1DF2590 Offset: 0x1DF0F90 VA: 0x181DF2590 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DF20A0 Offset: 0x1DF0AA0 VA: 0x181DF20A0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DF2870 Offset: 0x1DF1270 VA: 0x181DF2870
	private static void .cctor() { }
}

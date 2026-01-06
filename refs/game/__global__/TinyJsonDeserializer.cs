public class TinyJsonDeserializer // TypeDefIndex: 13379
{
	// Fields
	private TextReader reader; // 0x10
	private GameObject contextRoot; // 0x18
	private static readonly NumberFormatInfo numberFormat; // 0x0
	private StringBuilder builder; // 0x20

	// Methods

	// RVA: 0xBB3D80 Offset: 0xBB2780 VA: 0x180BB3D80
	public static object Deserialize(string text, Type type, object populate, GameObject contextRoot) { }

	// RVA: 0xBB3E90 Offset: 0xBB2890 VA: 0x180BB3E90
	private object Deserialize(Type tp, object populate) { }

	// RVA: 0xBB3D00 Offset: 0xBB2700 VA: 0x180BB3D00
	private Object DeserializeUnityObject() { }

	// RVA: 0xBB36A0 Offset: 0xBB20A0 VA: 0x180BB36A0
	private Object DeserializeUnityObjectInner() { }

	// RVA: 0xBB5280 Offset: 0xBB3C80 VA: 0x180BB5280
	private void EatWhitespace() { }

	// RVA: 0xBB5330 Offset: 0xBB3D30 VA: 0x180BB5330
	private void Eat(string s) { }

	// RVA: 0xBB50D0 Offset: 0xBB3AD0 VA: 0x180BB50D0
	private string EatUntil(string c, bool inString) { }

	// RVA: 0xBB56A0 Offset: 0xBB40A0 VA: 0x180BB56A0
	private bool TryEat(char c) { }

	// RVA: 0xBB4F40 Offset: 0xBB3940 VA: 0x180BB4F40
	private string EatField() { }

	// RVA: 0xBB5540 Offset: 0xBB3F40 VA: 0x180BB5540
	private void SkipFieldData() { }

	// RVA: 0xBB5780 Offset: 0xBB4180 VA: 0x180BB5780
	public void .ctor() { }

	// RVA: 0xBB5720 Offset: 0xBB4120 VA: 0x180BB5720
	private static void .cctor() { }
}

public class SprayStroke // TypeDefIndex: 1384
{
	// Fields
	public const int MIN_STROKE_LENGTH = 6;
	public const int ANGLE_THRESHOLD_DEG = 10;
	public const float MAX_STROKE_DEVIATION = 5;
	public const int FORWARD_SAMPLE_COUNT = 5;
	public UShort2 Start; // 0x10
	public UShort2 End; // 0x14
	public ESprayColor Color; // 0x18

	// Methods

	// RVA: 0x66C2B0 Offset: 0x66ACB0 VA: 0x18066C2B0
	public void .ctor(UShort2 start, UShort2 end, ESprayColor color) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x66B6A0 Offset: 0x66A0A0 VA: 0x18066B6A0
	public List<PixelData> GetPixelsFromStroke() { }

	// RVA: 0x66BB80 Offset: 0x66A580 VA: 0x18066BB80
	public static List<SprayStroke> GetStrokesFromPixels(List<UShort2> coords, ESprayColor color, SpraySurface surface) { }

	// RVA: 0x66C200 Offset: 0x66AC00 VA: 0x18066C200
	public void Serialize(BinaryWriter writer) { }

	// RVA: 0x66B560 Offset: 0x669F60 VA: 0x18066B560
	public static SprayStroke Deserialize(BinaryReader reader) { }
}

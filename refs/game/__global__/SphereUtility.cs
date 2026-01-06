public abstract class SphereUtility // TypeDefIndex: 479
{
	// Fields
	private const float k_HalfPI = 1.5707964;

	// Methods

	// RVA: 0xA91360 Offset: 0xA8FD60 VA: 0x180A91360
	public static Vector2 DirectionToSphericalCoordinate(Vector3 direction) { }

	// RVA: 0xA91880 Offset: 0xA90280 VA: 0x180A91880
	public static Vector3 SphericalCoordinateToDirection(Vector2 coord) { }

	// RVA: 0xA91520 Offset: 0xA8FF20 VA: 0x180A91520
	public static float RadiusAtHeight(float yPos) { }

	// RVA: 0xA918F0 Offset: 0xA902F0 VA: 0x180A918F0
	public static Vector3 SphericalToPoint(float yPosition, float radAngle) { }

	// RVA: 0xA91510 Offset: 0xA8FF10 VA: 0x180A91510
	public static float RadAngleToPercent(float radAngle) { }

	// RVA: 0xA91500 Offset: 0xA8FF00 VA: 0x180A91500
	public static float PercentToRadAngle(float percent) { }

	// RVA: 0xA91460 Offset: 0xA8FE60 VA: 0x180A91460
	public static float HeightToPercent(float yValue) { }

	// RVA: 0xA914D0 Offset: 0xA8FED0 VA: 0x180A914D0
	public static float PercentToHeight(float hPercent) { }

	// RVA: 0xA91130 Offset: 0xA8FB30 VA: 0x180A91130
	public static float AngleToReachTarget(Vector2 point, float targetAngle) { }

	// RVA: 0xA91190 Offset: 0xA8FB90 VA: 0x180A91190
	public static float Atan2Positive(float y, float x) { }

	// RVA: 0xA915E0 Offset: 0xA8FFE0 VA: 0x180A915E0
	public static Vector3 RotateAroundXAxis(Vector3 point, float angle) { }

	// RVA: 0xA91690 Offset: 0xA90090 VA: 0x180A91690
	public static Vector3 RotateAroundYAxis(Vector3 point, float angle) { }

	// RVA: 0xA91730 Offset: 0xA90130 VA: 0x180A91730
	public static Vector3 RotatePoint(Vector3 point, float xAxisRotation, float yAxisRotation) { }

	// RVA: 0xA91540 Offset: 0xA8FF40 VA: 0x180A91540
	public static Vector2 Rotate2d(Vector2 pos, float angle) { }

	// RVA: 0xA91480 Offset: 0xA8FE80 VA: 0x180A91480
	public static Vector2 Matrix2x2Mult(Vector4 matrix, Vector2 pos) { }

	// RVA: 0xA911C0 Offset: 0xA8FBC0 VA: 0x180A911C0
	public static void CalculateStarRotation(Vector3 star, out float xRotationAngle, out float yRotationAngle) { }

	// RVA: 0xA912F0 Offset: 0xA8FCF0 VA: 0x180A912F0
	public static Vector2 ConvertUVToSphericalCoordinate(Vector2 uv) { }

	// RVA: 0xA912B0 Offset: 0xA8FCB0 VA: 0x180A912B0
	public static Vector2 ConvertSphericalCoordateToUV(Vector2 sphereCoord) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}

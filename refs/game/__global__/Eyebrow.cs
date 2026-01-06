public class Eyebrow : MonoBehaviour // TypeDefIndex: 3112
{
	// Fields
	private const float eyebrowHeightMultiplier = 0.01;
	[SerializeField]
	private Vector3 EyebrowDefaultScale; // 0x20
	[SerializeField]
	private Vector3 EyebrowDefaultLocalPos; // 0x2C
	[SerializeField]
	protected Eyebrow.ESide Side; // 0x38
	[SerializeField]
	protected Transform Model; // 0x40
	[SerializeField]
	protected MeshRenderer Rend; // 0x48
	[SerializeField]
	[Header("Eyebrow Data - Readonly")]
	private Color col; // 0x50
	[SerializeField]
	private float scale; // 0x60
	[SerializeField]
	private float thickness; // 0x64
	[SerializeField]
	private float restingAngle; // 0x68

	// Methods

	// RVA: 0x9BB780 Offset: 0x9BA180 VA: 0x1809BB780
	public void SetScale(float _scale) { }

	// RVA: 0x9BB7E0 Offset: 0x9BA1E0 VA: 0x1809BB7E0
	public void SetThickness(float thickness) { }

	// RVA: 0x9BB5F0 Offset: 0x9B9FF0 VA: 0x1809BB5F0
	public void SetRestingAngle(float _angle) { }

	// RVA: 0x9BB6F0 Offset: 0x9BA0F0 VA: 0x1809BB6F0
	public void SetRestingHeight(float normalizedHeight) { }

	// RVA: 0x9BB5A0 Offset: 0x9B9FA0 VA: 0x1809BB5A0
	public void SetColor(Color _col) { }

	// RVA: 0x9BB840 Offset: 0x9BA240 VA: 0x1809BB840
	public void .ctor() { }
}

public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 9989
{
	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x60
	private int m_NumCommonHeaders; // 0x68
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly sbyte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x70
	private WebHeaderCollectionType m_Type; // 0x78
	private static readonly char[] HttpTrimCharacters; // 0x18
	private static WebHeaderCollection.RfcChar[] RfcCharMap; // 0x20

	// Properties
	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	public override int Count { get; }
	public override string[] AllKeys { get; }

	// Methods

	// RVA: 0x26CE400 Offset: 0x26CCE00 VA: 0x1826CE400
	private void NormalizeCommonHeaders() { }

	// RVA: 0x26CF830 Offset: 0x26CE230 VA: 0x1826CF830
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x26CD1C0 Offset: 0x26CBBC0 VA: 0x1826CD1C0
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x26CF7C0 Offset: 0x26CE1C0 VA: 0x1826CF7C0
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x26CE5A0 Offset: 0x26CCFA0 VA: 0x1826CE5A0
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x26CCCB0 Offset: 0x26CB6B0 VA: 0x1826CCCB0
	internal void AddInternal(string name, string value) { }

	// RVA: 0x26CD260 Offset: 0x26CBC60 VA: 0x1826CD260
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x26CE540 Offset: 0x26CCF40 VA: 0x1826CE540
	internal void RemoveInternal(string name) { }

	// RVA: 0x26CD2D0 Offset: 0x26CBCD0 VA: 0x1826CD2D0
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x26CD850 Offset: 0x26CC250 VA: 0x1826CD850
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x26CEC60 Offset: 0x26CD660 VA: 0x1826CEC60
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x26CCD20 Offset: 0x26CB720 VA: 0x1826CCD20 Slot: 15
	public override void Add(string name, string value) { }

	// RVA: 0x26CCEE0 Offset: 0x26CB8E0 VA: 0x1826CCEE0
	public void Add(string header) { }

	// RVA: 0x26CE9F0 Offset: 0x26CD3F0 VA: 0x1826CE9F0 Slot: 18
	public override void Set(string name, string value) { }

	// RVA: 0x26CE7B0 Offset: 0x26CD1B0 VA: 0x1826CE7B0
	internal void SetInternal(string name, string value) { }

	// RVA: 0x26CE690 Offset: 0x26CD090 VA: 0x1826CE690 Slot: 19
	public override void Remove(string name) { }

	// RVA: 0x26CDDA0 Offset: 0x26CC7A0 VA: 0x1826CDDA0 Slot: 17
	public override string[] GetValues(string header) { }

	// RVA: 0x26CEEA0 Offset: 0x26CD8A0 VA: 0x1826CEEA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x26CD8C0 Offset: 0x26CC2C0 VA: 0x1826CD8C0
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x26CF620 Offset: 0x26CE020 VA: 0x1826CF620
	public void .ctor() { }

	// RVA: 0x26CF680 Offset: 0x26CE080 VA: 0x1826CF680
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x26CF450 Offset: 0x26CDE50 VA: 0x1826CF450
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public override void OnDeserialization(object sender) { }

	// RVA: 0x26CDC20 Offset: 0x26CC620 VA: 0x1826CDC20 Slot: 11
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x26CEC30 Offset: 0x26CD630 VA: 0x1826CEC30 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x26CE040 Offset: 0x26CCA40 VA: 0x1826CE040 Slot: 16
	public override string Get(string name) { }

	// RVA: 0x26CDB60 Offset: 0x26CC560 VA: 0x1826CDB60 Slot: 13
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x26CF7F0 Offset: 0x26CE1F0 VA: 0x1826CF7F0 Slot: 14
	public override int get_Count() { }

	// RVA: 0x26CE3B0 Offset: 0x26CCDB0 VA: 0x1826CE3B0 Slot: 20
	public override string Get(int index) { }

	// RVA: 0x26CDFF0 Offset: 0x26CC9F0 VA: 0x1826CDFF0 Slot: 21
	public override string[] GetValues(int index) { }

	// RVA: 0x26CDBD0 Offset: 0x26CC5D0 VA: 0x1826CDBD0 Slot: 22
	public override string GetKey(int index) { }

	// RVA: 0x26CF770 Offset: 0x26CE170 VA: 0x1826CF770 Slot: 23
	public override string[] get_AllKeys() { }

	// RVA: 0x26CEEF0 Offset: 0x26CD8F0 VA: 0x1826CEEF0
	private static void .cctor() { }
}

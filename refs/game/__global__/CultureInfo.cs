public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 4854
{
	// Fields
	private static CultureInfo invariant_culture_info; // 0x0
	private static object shared_table_lock; // 0x8
	private static CultureInfo default_current_culture; // 0x10
	private bool m_isReadOnly; // 0x10
	private int cultureID; // 0x14
	private int parent_lcid; // 0x18
	private int datetime_index; // 0x1C
	private int number_index; // 0x20
	private int default_calendar_type; // 0x24
	private bool m_useUserOverride; // 0x28
	internal NumberFormatInfo numInfo; // 0x30
	internal DateTimeFormatInfo dateTimeInfo; // 0x38
	private TextInfo textInfo; // 0x40
	internal string m_name; // 0x48
	private string englishname; // 0x50
	private string nativename; // 0x58
	private string iso3lang; // 0x60
	private string iso2lang; // 0x68
	private string win3lang; // 0x70
	private string territory; // 0x78
	private string[] native_calendar_names; // 0x80
	private CompareInfo compareInfo; // 0x88
	private readonly void* textinfo_data; // 0x90
	private int m_dataItem; // 0x98
	private Calendar calendar; // 0xA0
	private CultureInfo parent_culture; // 0xA8
	private bool constructed; // 0xB0
	internal byte[] cached_serialized_form; // 0xB8
	internal CultureData m_cultureData; // 0xC0
	internal bool m_isInherited; // 0xC8
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	internal const int LOCALE_INVARIANT = 127;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; // 0x20
	private static Dictionary<int, CultureInfo> shared_by_number; // 0x28
	private static Dictionary<string, CultureInfo> shared_by_name; // 0x30
	private static CultureInfo s_UserPreferredCultureInfoInAppX; // 0x38
	internal static readonly bool IsTaiwanSku; // 0x40

	// Properties
	internal CultureData _cultureData { get; }
	internal bool _isInherited { get; }
	public static CultureInfo InvariantCulture { get; }
	public static CultureInfo CurrentCulture { get; }
	public static CultureInfo CurrentUICulture { get; }
	internal string Territory { get; }
	internal string _name { get; }
	public virtual int LCID { get; }
	public virtual string Name { get; }
	public virtual Calendar Calendar { get; }
	public virtual CultureInfo Parent { get; }
	public virtual TextInfo TextInfo { get; }
	public virtual string TwoLetterISOLanguageName { get; }
	public virtual CompareInfo CompareInfo { get; }
	public virtual bool IsNeutralCulture { get; }
	public virtual NumberFormatInfo NumberFormat { get; set; }
	public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
	public virtual string EnglishName { get; }
	internal int CalendarType { get; }
	public static CultureInfo DefaultThreadCurrentCulture { get; }
	public static CultureInfo DefaultThreadCurrentUICulture { get; }
	internal string SortName { get; }
	internal static CultureInfo UserDefaultUICulture { get; }
	internal static CultureInfo UserDefaultCulture { get; }
	internal bool HasInvariantCultureName { get; }

	// Methods

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	internal CultureData get__cultureData() { }

	// RVA: 0x1A3AE20 Offset: 0x1A39820 VA: 0x181A3AE20
	internal bool get__isInherited() { }

	// RVA: 0x1BDF280 Offset: 0x1BDDC80 VA: 0x181BDF280
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x1BDEEB0 Offset: 0x1BDD8B0 VA: 0x181BDEEB0
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x1BDEEE0 Offset: 0x1BDD8E0 VA: 0x181BDEEE0
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x1BDA3C0 Offset: 0x1BD8DC0 VA: 0x181BDA3C0
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x1BDA5B0 Offset: 0x1BD8FB0 VA: 0x181BDA5B0
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	internal string get_Territory() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal string get__name() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70 Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x1BDECD0 Offset: 0x1BDD6D0 VA: 0x181BDECD0 Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x1BDF3D0 Offset: 0x1BDDDD0 VA: 0x181BDF3D0 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x1BDF6A0 Offset: 0x1BDE0A0 VA: 0x181BDF6A0 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x1BDF850 Offset: 0x1BDE250 VA: 0x181BDF850 Slot: 11
	public virtual string get_TwoLetterISOLanguageName() { }

	// RVA: 0x1BDA190 Offset: 0x1BD8B90 VA: 0x181BDA190 Slot: 12
	public virtual object Clone() { }

	// RVA: 0x1BDD380 Offset: 0x1BDBD80 VA: 0x181BDD380 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1BDD9C0 Offset: 0x1BDC3C0 VA: 0x181BDD9C0
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	// RVA: 0x1BDDEC0 Offset: 0x1BDC8C0 VA: 0x181BDDEC0
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x1BDDEB0 Offset: 0x1BDC8B0 VA: 0x181BDDEB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BDED70 Offset: 0x1BDD770 VA: 0x181BDED70 Slot: 13
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x1BDF2E0 Offset: 0x1BDDCE0 VA: 0x181BDF2E0 Slot: 14
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CheckNeutral() { }

	// RVA: 0x1BDF320 Offset: 0x1BDDD20 VA: 0x181BDF320 Slot: 15
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x1BDFC30 Offset: 0x1BDE630 VA: 0x181BDFC30 Slot: 16
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x1BDEF10 Offset: 0x1BDD910 VA: 0x181BDEF10 Slot: 17
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x1BDFB40 Offset: 0x1BDE540 VA: 0x181BDFB40 Slot: 18
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x1BDF160 Offset: 0x1BDDB60 VA: 0x181BDF160 Slot: 19
	public virtual string get_EnglishName() { }

	// RVA: 0x1BDDDA0 Offset: 0x1BDC7A0 VA: 0x181BDDDA0 Slot: 20
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x1BDAA60 Offset: 0x1BD9460 VA: 0x181BDAA60
	private void Construct() { }

	// RVA: 0x1BDEC10 Offset: 0x1BDD610 VA: 0x181BDEC10
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x1BDEC20 Offset: 0x1BDD620 VA: 0x181BDEC20
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x1BDF950 Offset: 0x1BDE350 VA: 0x181BDF950
	private static string get_current_locale_name() { }

	// RVA: 0x1BDFB30 Offset: 0x1BDE530 VA: 0x181BDFB30
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	// RVA: 0x1BDA5F0 Offset: 0x1BD8FF0 VA: 0x181BDA5F0
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x1BDD2C0 Offset: 0x1BDBCC0 VA: 0x181BDD2C0
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x1BDEBF0 Offset: 0x1BDD5F0 VA: 0x181BDEBF0
	public void .ctor(int culture) { }

	// RVA: 0x1BDE860 Offset: 0x1BDD260 VA: 0x181BDE860
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x1BDE880 Offset: 0x1BDD280 VA: 0x181BDE880
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x1BDE820 Offset: 0x1BDD220 VA: 0x181BDE820
	public void .ctor(string name) { }

	// RVA: 0x1BDEBD0 Offset: 0x1BDD5D0 VA: 0x181BDEBD0
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x1BDE530 Offset: 0x1BDCF30 VA: 0x181BDE530
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x1BDE840 Offset: 0x1BDD240 VA: 0x181BDE840
	private void .ctor() { }

	// RVA: 0x1BDF960 Offset: 0x1BDE360 VA: 0x181BDF960
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x1BDD500 Offset: 0x1BDBF00 VA: 0x181BDD500
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x1BDD760 Offset: 0x1BDC160 VA: 0x181BDD760
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x1BDAC90 Offset: 0x1BD9690 VA: 0x181BDAC90
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x1BDCFA0 Offset: 0x1BDB9A0 VA: 0x181BDCFA0
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x1BDA9C0 Offset: 0x1BD93C0 VA: 0x181BDA9C0
	private bool ConstructLocaleFromName(string name) { }

	// RVA: 0x1BDADC0 Offset: 0x1BD97C0 VA: 0x181BDADC0
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x1BDEC30 Offset: 0x1BDD630 VA: 0x181BDEC30
	internal int get_CalendarType() { }

	// RVA: 0x1BDAA80 Offset: 0x1BD9480 VA: 0x181BDAA80
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x1BDAD20 Offset: 0x1BD9720 VA: 0x181BDAD20
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x1BDF0A0 Offset: 0x1BDDAA0 VA: 0x181BDF0A0
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x1BDF100 Offset: 0x1BDDB00 VA: 0x181BDF100
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal string get_SortName() { }

	// RVA: 0x1BDF8D0 Offset: 0x1BDE2D0 VA: 0x181BDF8D0
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x1BDF890 Offset: 0x1BDE290 VA: 0x181BDF890
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x1BDDEE0 Offset: 0x1BDC8E0 VA: 0x181BDDEE0
	private static extern void InitializeUserPreferredCultureInfoInAppX(CultureInfo.OnCultureInfoChangedDelegate onCultureInfoChangedInAppX) { }

	[MonoPInvokeCallback(typeof(CultureInfo.OnCultureInfoChangedDelegate))]
	// RVA: 0x1BDDF00 Offset: 0x1BDC900 VA: 0x181BDDF00
	private static void OnCultureInfoChangedInAppX(string language) { }

	// RVA: 0x1BDD410 Offset: 0x1BDBE10 VA: 0x181BDD410
	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX() { }

	// RVA: 0x1BDF1A0 Offset: 0x1BDDBA0 VA: 0x181BDF1A0
	internal bool get_HasInvariantCultureName() { }

	// RVA: 0x1BDDFE0 Offset: 0x1BDC9E0 VA: 0x181BDDFE0
	internal static bool VerifyCultureName(string cultureName, bool throwException) { }

	// RVA: 0x1BDE130 Offset: 0x1BDCB30 VA: 0x181BDE130
	private static void .cctor() { }
}

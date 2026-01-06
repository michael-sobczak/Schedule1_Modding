public class CredentialDialog : Component // TypeDefIndex: 17244
{
	// Fields
	private string _confirmTarget; // 0x28
	private NetworkCredential _credentials; // 0x30
	private bool _isSaveChecked; // 0x38
	private string _target; // 0x40
	private static readonly Dictionary<string, NetworkCredential> _applicationInstanceCredentialCache; // 0x0
	private string _caption; // 0x48
	private string _text; // 0x50
	private string _windowTitle; // 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler UserNameChanged; // 0x60
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventHandler PasswordChanged; // 0x68
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <UseApplicationInstanceCredentialCache>k__BackingField; // 0x70
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DownlevelTextMode <DownlevelTextMode>k__BackingField; // 0x74
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ShowSaveCheckBox>k__BackingField; // 0x78
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ShowUIForSavedCredentials>k__BackingField; // 0x79
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsStoredCredential>k__BackingField; // 0x7A
	private IContainer components; // 0x80

	// Properties
	[Category("Behavior")]
	[Description("Indicates whether to use the application instance credential cache.")]
	[DefaultValue(False)]
	public bool UseApplicationInstanceCredentialCache { get; set; }
	[DefaultValue(False)]
	[Description("Indicates whether the "Save password" checkbox is checked.")]
	[Category("Appearance")]
	public bool IsSaveChecked { get; set; }
	[Browsable(False)]
	public string Password { get; set; }
	[Browsable(False)]
	public NetworkCredential Credentials { get; }
	[Browsable(False)]
	public string UserName { get; set; }
	[Description("The target for the credentials, typically the server name prefixed by an application-specific identifier.")]
	[Category("Behavior")]
	[DefaultValue("")]
	public string Target { get; set; }
	[Description("The title of the credentials dialog.")]
	[Category("Appearance")]
	[Localizable(True)]
	[DefaultValue("")]
	public string WindowTitle { get; set; }
	[Localizable(True)]
	[Description("A brief message that will be displayed in the dialog box.")]
	[DefaultValue("")]
	[Category("Appearance")]
	public string MainInstruction { get; set; }
	[Category("Appearance")]
	[Localizable(True)]
	[Description("Additional text to display in the dialog.")]
	[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
	[DefaultValue("")]
	public string Content { get; set; }
	[Localizable(True)]
	[DefaultValue(0)]
	[Description("Indicates how the text of the MainInstruction and Content properties is displayed on Windows XP.")]
	[Category("Appearance")]
	public DownlevelTextMode DownlevelTextMode { get; set; }
	[Category("Appearance")]
	[Description("Indicates whether a check box is shown on the dialog that allows the user to choose whether to save the credentials or not.")]
	[DefaultValue(False)]
	public bool ShowSaveCheckBox { get; set; }
	[Category("Behavior")]
	[Description("Indicates whether the dialog should be displayed even when saved credentials exist for the specified target.")]
	[DefaultValue(False)]
	public bool ShowUIForSavedCredentials { get; set; }
	public bool IsStoredCredential { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E018D0 Offset: 0x1E002D0 VA: 0x181E018D0
	public void add_UserNameChanged(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E01C10 Offset: 0x1E00610 VA: 0x181E01C10
	public void remove_UserNameChanged(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E01830 Offset: 0x1E00230 VA: 0x181E01830
	public void add_PasswordChanged(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E01B70 Offset: 0x1E00570 VA: 0x181E01B70
	public void remove_PasswordChanged(EventHandler value) { }

	// RVA: 0x1E01740 Offset: 0x1E00140 VA: 0x181E01740
	public void .ctor() { }

	// RVA: 0x1E01620 Offset: 0x1E00020 VA: 0x181E01620
	public void .ctor(IContainer container) { }

	[CompilerGenerated]
	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	public bool get_UseApplicationInstanceCredentialCache() { }

	[CompilerGenerated]
	// RVA: 0x83DBC0 Offset: 0x83C5C0 VA: 0x18083DBC0
	public void set_UseApplicationInstanceCredentialCache(bool value) { }

	// RVA: 0x1E019D0 Offset: 0x1E003D0 VA: 0x181E019D0
	public bool get_IsSaveChecked() { }

	// RVA: 0x1E01CB0 Offset: 0x1E006B0 VA: 0x181E01CB0
	public void set_IsSaveChecked(bool value) { }

	// RVA: 0x1E01A40 Offset: 0x1E00440 VA: 0x181E01A40
	public string get_Password() { }

	// RVA: 0x1E01D00 Offset: 0x1E00700 VA: 0x181E01D00
	private void set_Password(string value) { }

	// RVA: 0x1E019C0 Offset: 0x1E003C0 VA: 0x181E019C0
	public NetworkCredential get_Credentials() { }

	// RVA: 0x1E01AC0 Offset: 0x1E004C0 VA: 0x181E01AC0
	public string get_UserName() { }

	// RVA: 0x1E01DF0 Offset: 0x1E007F0 VA: 0x181E01DF0
	private void set_UserName(string value) { }

	// RVA: 0x1E01A70 Offset: 0x1E00470 VA: 0x181E01A70
	public string get_Target() { }

	// RVA: 0x1E01DC0 Offset: 0x1E007C0 VA: 0x181E01DC0
	public void set_Target(string value) { }

	// RVA: 0x1E01B20 Offset: 0x1E00520 VA: 0x181E01B20
	public string get_WindowTitle() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_WindowTitle(string value) { }

	// RVA: 0x1E019F0 Offset: 0x1E003F0 VA: 0x181E019F0
	public string get_MainInstruction() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_MainInstruction(string value) { }

	// RVA: 0x1E01970 Offset: 0x1E00370 VA: 0x181E01970
	public string get_Content() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Content(string value) { }

	[CompilerGenerated]
	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0
	public DownlevelTextMode get_DownlevelTextMode() { }

	[CompilerGenerated]
	// RVA: 0xA9F810 Offset: 0xA9E210 VA: 0x180A9F810
	public void set_DownlevelTextMode(DownlevelTextMode value) { }

	[CompilerGenerated]
	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	public bool get_ShowSaveCheckBox() { }

	[CompilerGenerated]
	// RVA: 0x4E28E0 Offset: 0x4E12E0 VA: 0x1804E28E0
	public void set_ShowSaveCheckBox(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E01A60 Offset: 0x1E00460 VA: 0x181E01A60
	public bool get_ShowUIForSavedCredentials() { }

	[CompilerGenerated]
	// RVA: 0x1E01DB0 Offset: 0x1E007B0 VA: 0x181E01DB0
	public void set_ShowUIForSavedCredentials(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E019E0 Offset: 0x1E003E0 VA: 0x181E019E0
	public bool get_IsStoredCredential() { }

	[CompilerGenerated]
	// RVA: 0x1E01CF0 Offset: 0x1E006F0 VA: 0x181E01CF0
	private void set_IsStoredCredential(bool value) { }

	// RVA: 0x1E011E0 Offset: 0x1DFFBE0 VA: 0x181E011E0
	public DialogResult ShowDialog() { }

	// RVA: 0x1E00E70 Offset: 0x1DFF870 VA: 0x181E00E70
	public DialogResult ShowDialog(IWin32Window owner) { }

	// RVA: 0x1DFEBA0 Offset: 0x1DFD5A0 VA: 0x181DFEBA0
	public void ConfirmCredentials(bool confirm) { }

	// RVA: 0x1E011F0 Offset: 0x1DFFBF0 VA: 0x181E011F0
	public static void StoreCredential(string target, NetworkCredential credential) { }

	// RVA: 0x1E008C0 Offset: 0x1DFF2C0 VA: 0x181E008C0
	public static NetworkCredential RetrieveCredential(string target) { }

	// RVA: 0x1E006F0 Offset: 0x1DFF0F0 VA: 0x181E006F0
	public static NetworkCredential RetrieveCredentialFromApplicationInstanceCache(string target) { }

	// RVA: 0x1DFF2E0 Offset: 0x1DFDCE0 VA: 0x181DFF2E0
	public static bool DeleteCredential(string target) { }

	// RVA: 0x1DFF790 Offset: 0x1DFE190 VA: 0x181DFF790 Slot: 14
	protected virtual void OnUserNameChanged(EventArgs e) { }

	// RVA: 0x1DFF760 Offset: 0x1DFE160 VA: 0x181DFF760 Slot: 15
	protected virtual void OnPasswordChanged(EventArgs e) { }

	// RVA: 0x1E001F0 Offset: 0x1DFEBF0 VA: 0x181E001F0
	private bool PromptForCredentialsCredUI(IntPtr owner, bool storedCredentials) { }

	// RVA: 0x1DFF7C0 Offset: 0x1DFE1C0 VA: 0x181DFF7C0
	private bool PromptForCredentialsCredUIWin(IntPtr owner, bool storedCredentials) { }

	// RVA: 0x1DFEEC0 Offset: 0x1DFD8C0 VA: 0x181DFEEC0
	private NativeMethods.CREDUI_INFO CreateCredUIInfo(IntPtr owner, bool downlevelText) { }

	// RVA: 0x1E00DA0 Offset: 0x1DFF7A0 VA: 0x181E00DA0
	private bool RetrieveCredentials() { }

	// RVA: 0x1DFF670 Offset: 0x1DFE070 VA: 0x181DFF670
	private static byte[] EncryptPassword(string password) { }

	// RVA: 0x1DFF230 Offset: 0x1DFDC30 VA: 0x181DFF230
	private static string DecryptPassword(byte[] encrypted) { }

	// RVA: 0x1E00CC0 Offset: 0x1DFF6C0 VA: 0x181E00CC0
	private bool RetrieveCredentialsFromApplicationInstanceCache() { }

	// RVA: 0x1DFF5B0 Offset: 0x1DFDFB0 VA: 0x181DFF5B0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1DFF6F0 Offset: 0x1DFE0F0 VA: 0x181DFF6F0
	private void InitializeComponent() { }

	// RVA: 0x1E01590 Offset: 0x1DFFF90 VA: 0x181E01590
	private static void .cctor() { }
}

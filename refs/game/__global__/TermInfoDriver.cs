internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 3873
{
	// Fields
	private static int* native_terminal_size; // 0x0
	private static int terminal_size; // 0x8
	private static readonly string[] locations; // 0x10
	private TermInfoReader reader; // 0x10
	private int cursorLeft; // 0x18
	private int cursorTop; // 0x1C
	private string title; // 0x20
	private string titleFormat; // 0x28
	private bool cursorVisible; // 0x30
	private string csrVisible; // 0x38
	private string csrInvisible; // 0x40
	private string clear; // 0x48
	private string bell; // 0x50
	private string term; // 0x58
	private StreamReader stdin; // 0x60
	private CStreamWriter stdout; // 0x68
	private int windowWidth; // 0x70
	private int windowHeight; // 0x74
	private int bufferHeight; // 0x78
	private int bufferWidth; // 0x7C
	private char[] buffer; // 0x80
	private int readpos; // 0x88
	private int writepos; // 0x8C
	private string keypadXmit; // 0x90
	private string keypadLocal; // 0x98
	private bool inited; // 0xA0
	private object initLock; // 0xA8
	private bool initKeys; // 0xB0
	private string origPair; // 0xB8
	private string origColors; // 0xC0
	private string cursorAddress; // 0xC8
	private ConsoleColor fgcolor; // 0xD0
	private string setfgcolor; // 0xD8
	private string setbgcolor; // 0xE0
	private int maxColors; // 0xE8
	private bool noGetPosition; // 0xEC
	private Hashtable keymap; // 0xF0
	private ByteMatcher rootmap; // 0xF8
	private int rl_startx; // 0x100
	private int rl_starty; // 0x104
	private byte[] control_characters; // 0x108
	private static readonly int[] _consoleColorToAnsiCode; // 0x18
	private char[] echobuf; // 0x110
	private int echon; // 0x118

	// Properties
	public bool Initialized { get; }
	public int WindowHeight { get; }
	public int WindowWidth { get; }

	// Methods

	// RVA: 0x1CCE0E0 Offset: 0x1CCCAE0 VA: 0x181CCE0E0
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x1CCDBD0 Offset: 0x1CCC5D0 VA: 0x181CCDBD0
	private static string SearchTerminfo(string term) { }

	// RVA: 0x1CCE200 Offset: 0x1CCCC00 VA: 0x181CCE200
	private void WriteConsole(string str) { }

	// RVA: 0x1CCE620 Offset: 0x1CCD020 VA: 0x181CCE620
	public void .ctor(string term) { }

	// RVA: 0x6A52A0 Offset: 0x6A3CA0 VA: 0x1806A52A0 Slot: 5
	public bool get_Initialized() { }

	// RVA: 0x1CCC560 Offset: 0x1CCAF60 VA: 0x181CCC560 Slot: 6
	public void Init() { }

	// RVA: 0x1CCC2E0 Offset: 0x1CCACE0 VA: 0x181CCC2E0
	private void IncrementX() { }

	// RVA: 0x1CCE280 Offset: 0x1CCCC80 VA: 0x181CCE280
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x1CCE230 Offset: 0x1CCCC30 VA: 0x181CCE230
	public void WriteSpecialKey(char c) { }

	// RVA: 0x1CCD100 Offset: 0x1CCBB00 VA: 0x181CCD100
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x1CCD0B0 Offset: 0x1CCBAB0 VA: 0x181CCD0B0
	public bool IsSpecialKey(char c) { }

	// RVA: 0x1CCBBE0 Offset: 0x1CCA5E0 VA: 0x181CCBBE0
	private void GetCursorPosition() { }

	// RVA: 0x1CC8F20 Offset: 0x1CC7920 VA: 0x181CC8F20
	private void CheckWindowDimensions() { }

	// RVA: 0x1CCEDA0 Offset: 0x1CCD7A0 VA: 0x181CCEDA0 Slot: 7
	public int get_WindowHeight() { }

	// RVA: 0x1CCEDD0 Offset: 0x1CCD7D0 VA: 0x181CCEDD0 Slot: 8
	public int get_WindowWidth() { }

	// RVA: 0x1CC8DF0 Offset: 0x1CC77F0 VA: 0x181CC8DF0
	private void AddToBuffer(int b) { }

	// RVA: 0x1CC8F00 Offset: 0x1CC7900 VA: 0x181CC8F00
	private void AdjustBuffer() { }

	// RVA: 0x1CC9080 Offset: 0x1CC7A80 VA: 0x181CC9080
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x1CCBEC0 Offset: 0x1CCA8C0 VA: 0x181CCBEC0
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x1CCD320 Offset: 0x1CCBD20 VA: 0x181CCD320
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x1CCD070 Offset: 0x1CCBA70 VA: 0x181CCD070
	private bool InputPending() { }

	// RVA: 0x1CCD220 Offset: 0x1CCBC20 VA: 0x181CCD220
	private void QueueEcho(char c) { }

	// RVA: 0x1CCBA40 Offset: 0x1CCA440 VA: 0x181CCBA40
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x1CCB9F0 Offset: 0x1CCA3F0 VA: 0x181CCB9F0
	private void EchoFlush() { }

	// RVA: 0x1CCD870 Offset: 0x1CCC270 VA: 0x181CCD870
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x1CCD540 Offset: 0x1CCBF40 VA: 0x181CCD540 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1CCD600 Offset: 0x1CCC000 VA: 0x181CCD600 Slot: 9
	public string ReadLine() { }

	// RVA: 0x1CCD610 Offset: 0x1CCC010 VA: 0x181CCD610
	public string ReadToEnd() { }

	// RVA: 0x1CCD620 Offset: 0x1CCC020 VA: 0x181CCD620
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x1CCDD50 Offset: 0x1CCC750 VA: 0x181CCDD50 Slot: 10
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x1CC91D0 Offset: 0x1CC7BD0 VA: 0x181CC91D0
	private void CreateKeyMap() { }

	// RVA: 0x1CCC370 Offset: 0x1CCAD70 VA: 0x181CCC370
	private void InitKeys() { }

	// RVA: 0x1CC8C50 Offset: 0x1CC7650 VA: 0x181CC8C50
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x1CCE480 Offset: 0x1CCCE80 VA: 0x181CCE480
	private static void .cctor() { }
}

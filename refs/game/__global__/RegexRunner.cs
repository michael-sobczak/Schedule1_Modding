public abstract class RegexRunner // TypeDefIndex: 9570
{
	// Fields
	protected internal int runtextbeg; // 0x10
	protected internal int runtextend; // 0x14
	protected internal int runtextstart; // 0x18
	protected internal string runtext; // 0x20
	protected internal int runtextpos; // 0x28
	protected internal int[] runtrack; // 0x30
	protected internal int runtrackpos; // 0x38
	protected internal int[] runstack; // 0x40
	protected internal int runstackpos; // 0x48
	protected internal int[] runcrawl; // 0x50
	protected internal int runcrawlpos; // 0x58
	protected internal int runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private int _timeout; // 0x70
	private bool _ignoreTimeout; // 0x74
	private int _timeoutOccursAt; // 0x78
	private const int TimeoutCheckFrequency = 1000;
	private int _timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected internal void .ctor() { }

	// RVA: 0x263A5A0 Offset: 0x2638FA0 VA: 0x18263A5A0
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x263A9E0 Offset: 0x26393E0 VA: 0x18263A9E0
	private void StartTimeoutWatch() { }

	// RVA: 0x2639A10 Offset: 0x2638410 VA: 0x182639A10
	protected void CheckTimeout() { }

	// RVA: 0x2639C00 Offset: 0x2638600 VA: 0x182639C00
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount();

	// RVA: 0x263A040 Offset: 0x2638A40 VA: 0x18263A040
	private void InitMatch() { }

	// RVA: 0x263AA10 Offset: 0x2639410 VA: 0x18263AA10
	private Match TidyMatch(bool quick) { }

	// RVA: 0x2639EF0 Offset: 0x26388F0 VA: 0x182639EF0
	protected void EnsureStorage() { }

	// RVA: 0x263A2F0 Offset: 0x2638CF0 VA: 0x18263A2F0
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x263A3E0 Offset: 0x2638DE0 VA: 0x18263A3E0
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x2639E40 Offset: 0x2638840 VA: 0x182639E40
	protected void DoubleTrack() { }

	// RVA: 0x2639D90 Offset: 0x2638790 VA: 0x182639D90
	protected void DoubleStack() { }

	// RVA: 0x2639CE0 Offset: 0x26386E0 VA: 0x182639CE0
	protected void DoubleCrawl() { }

	// RVA: 0x2639AF0 Offset: 0x26384F0 VA: 0x182639AF0
	protected void Crawl(int i) { }

	// RVA: 0x263A560 Offset: 0x2638F60 VA: 0x18263A560
	protected int Popcrawl() { }

	// RVA: 0x2639BE0 Offset: 0x26385E0 VA: 0x182639BE0
	protected int Crawlpos() { }

	// RVA: 0x2639980 Offset: 0x2638380 VA: 0x182639980
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x263AA80 Offset: 0x2639480 VA: 0x18263AA80
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x263ABB0 Offset: 0x26395B0 VA: 0x18263ABB0
	protected void Uncapture() { }

	// RVA: 0x263A4D0 Offset: 0x2638ED0 VA: 0x18263A4D0
	protected bool IsMatched(int cap) { }

	// RVA: 0x263A500 Offset: 0x2638F00 VA: 0x18263A500
	protected int MatchIndex(int cap) { }

	// RVA: 0x263A530 Offset: 0x2638F30 VA: 0x18263A530
	protected int MatchLength(int cap) { }
}

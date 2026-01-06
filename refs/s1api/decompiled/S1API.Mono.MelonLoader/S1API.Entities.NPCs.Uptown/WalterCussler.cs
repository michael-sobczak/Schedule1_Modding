using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class WalterCussler : NPC
{
	public new static string NPCId => "walter_cussler";

	internal WalterCussler()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "walter_cussler"))
	{
	}
}

using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class PeggyMyers : NPC
{
	public new static string NPCId => "peggy_myers";

	internal PeggyMyers()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "peggy_myers"))
	{
	}
}

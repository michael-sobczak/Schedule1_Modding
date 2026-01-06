using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class ChloeBowers : NPC
{
	public new static string NPCId => "chloe_bowers";

	internal ChloeBowers()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "chloe_bowers"))
	{
	}
}

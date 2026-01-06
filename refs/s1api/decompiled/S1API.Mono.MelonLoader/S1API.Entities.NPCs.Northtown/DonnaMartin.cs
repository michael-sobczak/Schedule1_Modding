using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class DonnaMartin : NPC
{
	public new static string NPCId => "donna_martin";

	internal DonnaMartin()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "donna_martin"))
	{
	}
}

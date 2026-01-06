using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class MegCooley : NPC
{
	public new static string NPCId => "meg_cooley";

	internal MegCooley()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "meg_cooley"))
	{
	}
}

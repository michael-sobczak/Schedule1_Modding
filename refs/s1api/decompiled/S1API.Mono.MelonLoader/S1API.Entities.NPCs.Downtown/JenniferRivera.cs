using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class JenniferRivera : NPC
{
	public new static string NPCId => "jennifer_rivera";

	internal JenniferRivera()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "jennifer_rivera"))
	{
	}
}

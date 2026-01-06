using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class JenHeard : NPC
{
	public new static string NPCId => "jen_heard";

	internal JenHeard()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "jen_heard"))
	{
	}
}

using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class EugeneBuckley : NPC
{
	public new static string NPCId => "eugene_buckley";

	internal EugeneBuckley()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "eugene_buckley"))
	{
	}
}

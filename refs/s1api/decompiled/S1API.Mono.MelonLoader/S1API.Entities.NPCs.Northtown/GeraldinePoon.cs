using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class GeraldinePoon : NPC
{
	public new static string NPCId => "geraldine_poon";

	internal GeraldinePoon()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "geraldine_poon"))
	{
	}
}

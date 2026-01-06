using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class KimDelaney : NPC
{
	public new static string NPCId => "kim_delaney";

	internal KimDelaney()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "kim_delaney"))
	{
	}
}

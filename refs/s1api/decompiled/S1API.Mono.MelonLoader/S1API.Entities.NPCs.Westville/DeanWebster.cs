using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class DeanWebster : NPC
{
	public new static string NPCId => "dean_webster";

	internal DeanWebster()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "dean_webster"))
	{
	}
}

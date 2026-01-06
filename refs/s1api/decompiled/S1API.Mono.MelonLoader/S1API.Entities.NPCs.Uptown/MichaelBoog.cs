using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class MichaelBoog : NPC
{
	public new static string NPCId => "michael_boog";

	internal MichaelBoog()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "michael_boog"))
	{
	}
}

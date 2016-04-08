using UnityEngine;
using Rewired;

public class ControllerTest : MonoBehaviour {
	public int playerId = 0;
	private Player player;

	void Awake() {
		player = ReInput.players.GetPlayer(playerId);

	}

	void Update() {
		if(player.GetAxis("MoveHorizontal") != 0.0f) {
			Debug.Log("Move Horizontal!");
		}


		}
}   
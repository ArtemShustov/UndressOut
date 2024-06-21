using UnityEngine;

namespace Game {
	public class BallDestroyer: MonoBehaviour, IBallInteractable {
		public void OnHit(Ball ball, Collision2D collision) {
			Destroy(ball.gameObject);
		}
	}
}
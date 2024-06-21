using UnityEngine;

namespace Game {
	public class Platform: MonoBehaviour, IBallInteractable {
		public void OnHit(Ball ball, Collision2D collision) {
			ball.ReflectMovement(collision.contacts[0].normal);
		}
	}
}
using UnityEngine;

namespace Game {
	public class CloneBonus: MonoBehaviour, IBallInteractable {
		public void OnHit(Ball ball, Collision2D collision) {
			SpawnClone(ball, collision, Vector2.right);
			SpawnClone(ball, collision, Vector2.left);
			Destroy(gameObject);

			Ball SpawnClone(Ball ball, Collision2D collision, Vector2 add) {
				var clone = Instantiate(ball);
				clone.transform.position = ball.transform.position;
				clone.SetMovementDirection(collision.otherRigidbody.velocity.normalized + add);
				return clone;
			}
		}
	}
}
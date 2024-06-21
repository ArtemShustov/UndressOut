using UnityEngine;

namespace Game {
	public interface IBallInteractable {
		void OnHit(Ball ball, Collision2D collision);
	}
}

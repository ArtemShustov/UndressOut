using UnityEngine;

namespace Game {
	[RequireComponent(typeof(Rigidbody2D))]
	public class Ball: MonoBehaviour {
		[SerializeField] private float _speed = 2;

		private Rigidbody2D _rigidbody;

		private void Awake() {
			_rigidbody = GetComponent<Rigidbody2D>();
			_rigidbody.velocity = Vector2.up * _speed;
		}

		public void SetMovementDirection(Vector2 direction) {
			_rigidbody.velocity = direction.normalized * _speed;
		}
		public void ReflectMovement(Vector2 normal) {
			SetMovementDirection(Vector2.Reflect(_rigidbody.velocity, normal));
		}

		private void OnCollisionEnter2D(Collision2D collision) {
			if (collision.collider.TryGetComponent<IBallInteractable>(out var interactable)) {
				interactable.OnHit(this, collision);
			}
		}
	}
}
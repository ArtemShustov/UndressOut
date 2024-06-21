using UnityEngine;

namespace Game.Utils {
	[RequireComponent(typeof(Camera))]
	public class CameraMinSize: MonoBehaviour {
		[SerializeField] private float _minVerticalSize = 1;
		private Camera _camera;
		
		private float _initalSize;
		private float _targetAspect;

		private void Awake() {
			_camera = GetComponent<Camera>();
		}
		private void Start() {
			_initalSize = _camera.orthographicSize;
			_targetAspect = _camera.aspect;
		}
		private void Update() {
			if (_camera.orthographic) {
				var newSize = _initalSize * (_targetAspect / _camera.aspect);
				_camera.orthographicSize = Mathf.Clamp(newSize, _minVerticalSize, newSize);
			}
		}
	}
}
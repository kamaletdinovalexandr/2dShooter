using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	[SerializeField] private Rigidbody2D _playerView;
	[SerializeField] private List<Rigidbody2D> _enemiesView;
	[SerializeField] private GameObject _projectilePrefab;
	private PlayerModel _playerModel;
	private List<EnemyModel> _enemyModels;
	private float _playerSpeed = 20f;
	private float _playerJumpForce = 4f;
	private float _projectileSpeed = 60f;
	private bool _leftDirection = false;

	private void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");

		if (moveHorizontal > 0f)
			_leftDirection = false;
		if (moveHorizontal < 0f)
			_leftDirection = true;
		
		Vector2 movement = new Vector2 (moveHorizontal, 0f);
		_playerView.AddForce (movement * _playerSpeed);
	
		if (Input.GetKeyDown((KeyCode.Space))) {
			_playerView.AddForce(new Vector2(0f, _playerJumpForce), ForceMode2D.Impulse);
		}

		if (Input.GetKeyDown(KeyCode.LeftAlt)) {
			var projectile = Instantiate(_projectilePrefab);
			projectile.transform.position = _playerView.gameObject.transform.position;
			
			var velocity = new Vector2();
			if (_leftDirection)
				velocity.x = -1f;
			else
				velocity.x = 1f;
			projectile.GetComponent<Rigidbody2D>().velocity = velocity * _projectileSpeed;
		}
	}

	private void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "enemy")
			Destroy(other.gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	[SerializeField] private PlayerView _playerView;
	private PlayerPresenter _playerPresenter;
	
	private void Awake() {
		var startPosition = _playerView.transform.position; 
		_playerPresenter = new PlayerPresenter(startPosition, _playerView);
	}

	private void FixedUpdate() {
		Vector2 direction = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		_playerPresenter.MoveModel(direction);

	}
	
}

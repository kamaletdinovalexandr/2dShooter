using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour {

	private PlayerPresenter _playerPresenter;

	public PlayerView(PlayerPresenter presenter) {
		_playerPresenter = presenter;
		
	}

	private void OnPositionChangerd(Vector2 position) {
		transform.position = position;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour {
	private PlayerPresenter _playerPresenter;

	public EnemyView(PlayerPresenter presenter) {
		_playerPresenter = presenter;
		
	}

	private void OnPositionChangerd(Vector2 position) {
		transform.position = position;
	}

	
}

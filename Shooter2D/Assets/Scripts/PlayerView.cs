using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour {

	private PlayerPresenter _playerPresenter;

	public void Init(PlayerPresenter presenter) {
		_playerPresenter = presenter;
		_playerPresenter.Model.PositionChanged += OnPositionChanged;

	}

	private void OnPositionChanged(Vector2 position) {
		transform.position = position;
	}
}

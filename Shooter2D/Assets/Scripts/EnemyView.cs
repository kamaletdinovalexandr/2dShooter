using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour {

	private EnemyPresenter _enemyPresenter;

	public void Init(EnemyPresenter presenter) {
		_enemyPresenter = presenter;
		_enemyPresenter.Model.PositionChanged += OnPositionChanged;

	}

	private void OnPositionChanged(Vector2 position) {
		transform.position = position;
	}
}

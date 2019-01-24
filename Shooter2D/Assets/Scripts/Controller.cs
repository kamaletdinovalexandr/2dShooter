using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	[SerializeField] private PlayerView _playerView;
	private PlayerPresenter _playerPresenter;
	[SerializeField] private EnemyView _enemyView;
	private EnemyPresenter _enemyPresenter;
	
	private void Awake()
	{
		InitPlayerPresenter();
		InitEnemyPresenter();
	}

	private void InitEnemyPresenter() {
		var enemyStartPosition = _enemyView.transform.position;
		_enemyPresenter = new EnemyPresenter(enemyStartPosition, _enemyView);
	}

	private void InitPlayerPresenter() {
		var playerStartPosition = _playerView.transform.position;
		_playerPresenter = new PlayerPresenter(playerStartPosition, _playerView);
	}

	private void FixedUpdate() {
		Vector2 direction = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		_playerPresenter.MoveModel(direction);
		_enemyPresenter.MoveModel(_playerPresenter.Model.Position);

		var playerModel = _playerPresenter.Model;
		var enemyModel = _enemyPresenter.Model;
		if (CheckColliding(playerModel.Position, playerModel.Size, 
					   enemyModel.Position, enemyModel.Size))
			Debug.Log("Colliding");
	}

	private bool CheckColliding(Vector2 position1, float size1, Vector2 position2, float size2) {
		
	}
	
}

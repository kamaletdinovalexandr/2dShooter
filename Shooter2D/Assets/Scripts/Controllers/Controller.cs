using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Controllers;

public class Controller : MonoBehaviour {

	[SerializeField] private PlayerView _playerView;
	private IPresenter _playerPresenter;
	[SerializeField] private EnemyView _enemyView;
	private IPresenter _enemyPresenter;
    public ColliderInteractor Interactor;
	
	private void Awake() {
		Init();
	}

	private void Init() {
        var playerStartPosition = _playerView.transform.position;
        _playerPresenter = new PlayerPresenter(playerStartPosition, _playerView);
        var enemyStartPosition = _enemyView.transform.position;
        _enemyPresenter = new EnemyPresenter(enemyStartPosition, _enemyView);
    }

	private void FixedUpdate() {
		Vector2 direction = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		_playerPresenter.MoveModel(direction);
        ColliderInteractor.CheckCollide();

        if (_enemyPresenter == null)
            return;

        _enemyPresenter.UpdateView();

        if (_enemyPresenter.GetModel().isCollided) {
            Debug.Log("Enemy is destroyed by colliding");
            _enemyPresenter.DestroyModel();
            _enemyPresenter = null;
        }
        
    }
}

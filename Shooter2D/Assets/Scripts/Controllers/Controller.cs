using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Controllers;

public class Controller : MonoBehaviour {

    [SerializeField] private Button _restartButton;
	[SerializeField] private PlayerView _playerView;
    [SerializeField] private EnemyView _enemyView;

    private IPresenter _playerPresenter;
	private IPresenter _enemyPresenter;
    public ColliderInteractor Interactor;
	
	private void Awake() {
		Init();
	}

	private void Init() {
        _restartButton.onClick.AddListener(OnRestartButtonClick);
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

    private void OnRestartButtonClick() {
       SceneManager.LoadScene("Main");
    }
}

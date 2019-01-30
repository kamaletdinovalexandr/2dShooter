
using Controllers;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UseCases;

public class PlayerPresenter : IPresenter{
    public IModel _playerModel;
    public PlayerView _playerView;

    public PlayerPresenter(Vector2 startPosition, PlayerView playerView) {
        _playerModel = new PlayerModel(startPosition, 1f, 20f );
        _playerView = playerView;
        UpdateView();
    }

    public IModel Model {
        get { return _playerModel; }
        
    }
    
    public void MoveModel(Vector2 direction) {
        _playerModel.Move(direction);
        UpdateView();
    }

    public void UpdateView() {
        _playerView.UpdateView(_playerModel);
    }
    
   
}

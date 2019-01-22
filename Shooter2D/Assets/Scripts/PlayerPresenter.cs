
using UnityEngine;

public class PlayerPresenter {
    public PlayerModel _playerModel;
    public PlayerView _playerView;

    public PlayerPresenter(Vector2 startPosition, PlayerView playerView) {
        _playerModel = new PlayerModel(new Vector2(0, 0), 6, 20f );
        _playerView = playerView;
        _playerView.Init(this);
    }

    public PlayerModel Model {
        get { return _playerModel; }
        
    }
    
    public void MoveModel(Vector2 direction) {
        _playerModel.Move(direction);
    }
    
   
}

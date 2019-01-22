
using UnityEngine;

public class PlayerPresenter {
    public PlayerModel _playerModel;
    public PlayerView _playerView;

    public PlayerPresenter() {
        _playerModel = new PlayerModel(new Vector2(0, 0), 6, 20f );
        _playerView = AddComponent<PlayerView>() as PlayerView;
    }
    
}

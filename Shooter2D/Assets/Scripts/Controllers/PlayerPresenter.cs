
using Controllers;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UseCases;

public class PlayerPresenter : IPresenter{
    private IModel PlayerModel;
    private PlayerView _playerView;

    public PlayerPresenter(Vector2 startPosition, PlayerView playerView) {
        PlayerModel = new PlayerModel(startPosition, 1f, 20f );
        _playerView = playerView;
        UpdateView();
        ColliderInteractor.AddModel(PlayerModel);
    }
    
    public IModel GetModel() {
        return PlayerModel;
    }

    public void MoveModel(Vector2 direction) {
        PlayerModel.Move(direction);
        UpdateView();
    }

    public void UpdateView() {
        _playerView.UpdateView(PlayerModel);
    }

    public void DestroyModel() {
        _playerView.Destroy();
        ColliderInteractor.RemoveModel(PlayerModel);
        PlayerModel = null;
    }

}

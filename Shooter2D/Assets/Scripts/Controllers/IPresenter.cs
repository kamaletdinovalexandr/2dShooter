using UnityEngine;
using UseCases;

namespace Controllers {
    public interface IPresenter {
        void MoveModel(Vector2 direction);
        void UpdateView();
        IModel GetModel();
        void DestroyModel();
    }
}
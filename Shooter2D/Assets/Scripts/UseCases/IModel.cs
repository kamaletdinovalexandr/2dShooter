using UnityEngine;

namespace UseCases {
    public interface IModel {
        Vector2 Position { get; }
        float Size { get; }
        bool isCollided { get; set; }
        void Move(Vector2 direction);
  
    }
}
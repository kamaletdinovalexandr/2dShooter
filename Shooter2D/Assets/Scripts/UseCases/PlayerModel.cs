using System;
using UnityEngine;

namespace UseCases {

	public class PlayerModel : IModel {
		public Vector2 Position { get; private set; }
		public float Size { get; private set; }
		public float MoveSpeed { get; private set; }
		public bool isCollided { get; set; }
        public ModelType CurrentModelType = ModelType.Player;

		public PlayerModel(Vector2 position, float size, float moveSpeed) {
            Position = position;
			Size = size;
			MoveSpeed = moveSpeed;
		}

		public void Move(Vector2 direction) {
			Position += direction * Time.deltaTime * MoveSpeed;
		}
	}
}

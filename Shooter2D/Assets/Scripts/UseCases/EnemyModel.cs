using System;
using UnityEngine;
using UseCases;

namespace UseCases {

	public class EnemyModel : IModel {
		public Vector2 Position { get; private set; }
		public float Size { get; private set; }
		public float MoveSpeed { get; private set; }

		public bool isCollided { get; set; }

		public EnemyModel(Vector2 position, float size, float moveSpeed) {
			Position = position;
			Size = size;
			MoveSpeed = moveSpeed;
		}

		public void Move(Vector2 direction) {
			Position += direction * Time.deltaTime * MoveSpeed;
		}
	}
}

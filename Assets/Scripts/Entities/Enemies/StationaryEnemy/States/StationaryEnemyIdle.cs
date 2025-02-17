﻿using UnityEngine;
using Utility;

namespace Entities.Enemies.StationaryEnemy.States
{
    public class StationaryEnemyIdle : StationaryEnemyState
    {
        private bool _hasDetectedPlayer;
        
        public StationaryEnemyIdle(StationaryEnemyController controller) : base(controller)
        {
        }

        public override void Enter()
        {
            Controller.body.linearVelocity = Vector2.zero;
        }
        
        public override void Update()
        {
            _hasDetectedPlayer = DetectCollider(UnityTag.Player);
        }

        protected override void SetTransitions()
        {
            AddTransition(StationaryEnemyStateType.Alert, () => _hasDetectedPlayer);
        }
    }
}
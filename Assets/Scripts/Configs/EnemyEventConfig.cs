﻿using System;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "EnemyEventConfig", menuName = "Configs/EnemyEventConfig")]
    public class EnemyEventConfig : ScriptableObject
    {
        public static Action OnEnemyHurt;
    }
}
﻿using Entities.Player;
using Entities.Player.Factories;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "MorphConfig", menuName = "Configs/MorphConfig", order = 0)]
    public class MorphConfig : ScriptableObject
    {
        [Header("General")]
        public MorphType type;
        public GameObject prefab;
        public float enemyKnockbackForce;
        public float selfKnockbackForce;
        public float armorPenetration;
        public Vector2 collisionPointOffset;
        public Vector2 collisionBox;
        public float damage;
        [Range(0f, 1f)] public float shakeIntensity;
        public float bloodCost;
        
        [Header("Projectile specific")]
        public float speed;
        public int count;
        public float angle;
        
        [Header("Cannon specific")]
        public bool hasFireRate;
        public float fireRate;
        public float maxLength;
    }
}
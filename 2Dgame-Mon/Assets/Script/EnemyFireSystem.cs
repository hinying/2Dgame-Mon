using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// 敵人子彈發射
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("生成子彈間隔"), Range(0, 3)]
        private float interval = 0.5f;

        private void Awake()
        {
            //SpawnBullet();

            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}


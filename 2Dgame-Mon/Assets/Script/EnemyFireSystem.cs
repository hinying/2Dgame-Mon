using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// �ĤH�l�u�o�g
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("�ͦ��l�u���j"), Range(0, 3)]
        private float interval = 0.5f;

        private void Awake()
        {
            //SpawnBullet();

            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}


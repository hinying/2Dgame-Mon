using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// ���a�l�u�o�g
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }        
    }
}


using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// 玩家子彈發射
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


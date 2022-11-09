using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// ª±®a¤l¼uµo®g
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


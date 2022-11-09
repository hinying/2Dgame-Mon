using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// 發射系統基底
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpwan;

        //生成子彈
        protected void SpawnBullet()
        {
            Instantiate(prefabBullet,
                pointSpwan.position,
                pointSpwan.rotation);
        }

    }
}

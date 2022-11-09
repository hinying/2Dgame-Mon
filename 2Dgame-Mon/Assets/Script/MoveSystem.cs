using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// 移動系統
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-5, 5)]
        private float speed = -1f;

        private void Update()
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

    }

}
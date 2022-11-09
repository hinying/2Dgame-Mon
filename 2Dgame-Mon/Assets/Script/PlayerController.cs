using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// 玩家控制
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 5f;
        

        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");


            transform.Translate(
                speedHorizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v,
                0);

            if (v < 0)
            {
                print("往上");
            }

            if (v > 0)
            {
                print("往上");
            } 
            
            if (v == 0)
            {
                print("中間");
            }

        }

    }
}

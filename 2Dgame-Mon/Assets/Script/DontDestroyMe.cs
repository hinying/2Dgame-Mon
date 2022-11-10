using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// 記得此物
    /// </summary>
    public class DontDestroyMe : MonoBehaviour
    {
        void Start()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

}

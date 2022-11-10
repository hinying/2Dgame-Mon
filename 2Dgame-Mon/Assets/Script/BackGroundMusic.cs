using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// 背景音樂
    /// </summary>
    public class BackGroundMusic : MonoBehaviour
    {
        public GameObject TitleBGM;
        GameObject BGM = null;
        // Start is called before the first frame update
        void Start()
        {
            BGM = GameObject.FindGameObjectWithTag("Sound");
            if (BGM == null)
            {
                BGM = Instantiate(TitleBGM);
            }
        }
    }
}


using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace HSIN
{
    /// <summary>
    /// 切換場景
    /// </summary>
    public class ChangeScene : MonoBehaviour
    {
        void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(OnClick);
        }

        void OnClick()
        {
            SceneManager.LoadScene("game");

        }
    }
}
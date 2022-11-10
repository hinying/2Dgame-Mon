using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace HSIN
{
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
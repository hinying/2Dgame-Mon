using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// �ˮ`�t��
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�z���w�s��")]
        private GameObject prefabExplosion;
        [SerializeField, Header("�I��|�z�����W��")]
        private string nameTarget;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);

            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(
                    prefabExplosion,
                    transform.position,
                    transform.rotation);

                Destroy(gameObject);
                
            }

        }

    }
}
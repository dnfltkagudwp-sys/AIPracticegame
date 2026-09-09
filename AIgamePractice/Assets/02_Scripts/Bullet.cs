using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 2f);
        //Invoke("Destroyself", 2f);
    }
}


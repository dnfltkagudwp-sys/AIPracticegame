using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.05f;
    public GameObject BulletPrefab;
    public float BulletSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, speed, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -speed, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*
            GameObject Bullet = Instantiate(BulletPrefab);
            Bullet.transform.position = this.gameObject.transform.position + new Vector3(0f, 0.5f, 0f);
            Bullet.GetComponent<Rigidbody>().AddForce(Vector3.up * BulletSpeed);

            GameObject Bullet1 = Instantiate(BulletPrefab);
            Bullet1.transform.position = this.gameObject.transform.position + new Vector3(0f, 1f, 0f);
            Bullet1.GetComponent<Rigidbody>().AddForce(Vector3.up * BulletSpeed);

            GameObject Bullet2 = Instantiate(BulletPrefab);
            Bullet2.transform.position = this.gameObject.transform.position + new Vector3(0f, 1.5f, 0f);
            Bullet2.GetComponent<Rigidbody>().AddForce(Vector3.up * BulletSpeed);
            */
            for (int i = 1; i <= 3; i++)
            {
                GameObject Bullet = Instantiate(BulletPrefab);
                Bullet.transform.position = this.gameObject.transform.position + new Vector3(0f, i * 0.5f, 0f);
                Bullet.GetComponent<Rigidbody>().AddForce(Vector3.up * BulletSpeed);
            }

        }
    }
}
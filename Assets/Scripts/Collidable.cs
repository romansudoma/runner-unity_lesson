using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float moveSpeed = 20f;
    public float timeAmount = 1.5f;

    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
        if (Time.frameCount % 100 == 0)
            moveSpeed += 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.AdjustTime(timeAmount);
            Destroy(gameObject);
        }
    }
}

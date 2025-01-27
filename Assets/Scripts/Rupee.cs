using UnityEngine;

public class Rupee : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start Rupee");
        //transform.position = new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with " + collision.gameObject.name);        

        if (collision.gameObject.name == "link")
        {
            Destroy(gameObject);
        }          
    }
}
 
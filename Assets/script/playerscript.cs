using UnityEngine;

public class playerscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rigidbody;
    public float force = 25f;
    public float speed = 15f;
    public float maxX;
    public float minX;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = transform.position;
        if (playerpos.x < minX)
        {
            playerpos.x = minX;
        }
        transform.position = playerpos;
        if (playerpos.x > maxX)
        {
            playerpos.x = maxX;
        }
        transform.position = playerpos;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(15f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position - new Vector3(15f * Time.deltaTime, 0, 0);
        }

    }
    private void FixedUpdate()
    {
        rigidbody.linearVelocity = new Vector3(rigidbody.linearVelocity.x, rigidbody.linearVelocity.y, 25f);
        //rigidbody.AddForce(0, 0, 400f * Time.deltaTime);
    }

}



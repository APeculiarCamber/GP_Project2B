using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        //play audio of drop
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(0, -speed * Time.fixedDeltaTime, 0));

        if (transform.position.y < -6) Destroy(gameObject);
    }

    public void setSpeed(float s)
    {
        speed = s;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        string oTag = other.gameObject.tag;
        if (oTag == "Picker" || oTag == "PlayerShot")
        {
            Destroy(gameObject);
        }
    }
}

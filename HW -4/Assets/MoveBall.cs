using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBall : MonoBehaviour
{
    Rigidbody rb;
    public int ballSpeed;
    public GameObject winText;
    bool jump = false;
    float horizontalMove = 0f;
    public Transform t;
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jump == false)
        {
            rb.AddForce(Vector3.up * 850);
            jump = true;
        }

        if (t.transform.position.y <= -30)
            gameManager.CompleteLevel();



        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene("level 2");

        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");

        Vector3 ballMove = new Vector3(hMove, 0.0f, vMove);

        rb.AddForce(ballMove* ballSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            winText.SetActive(true);
        }
        if (collision.gameObject.tag == "Plane")
            jump = false;
        
    }
}

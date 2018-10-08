using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermover : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    public Text count;
    public Text wintext;
    private float number;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        number = 0;
        wintext.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        float movehorontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        Vector3 movee = new Vector3(movehorontal,0.0f,movevertical);
        rb.AddForce(movee * speed);
        if (number == 9)
        {
            wintext.text = "You Win";
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick_ups"))
        {
            other.gameObject.SetActive(false);
            number = number + 1;
            count.text = "Count: " + number.ToString();

        }
    }
}

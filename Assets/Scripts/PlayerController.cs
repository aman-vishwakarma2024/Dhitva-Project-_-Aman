using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public TextMeshProUGUI countText, winText;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        count=0;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float moveHorizontal=Input.GetAxis("Horizontal");
        float movevertical=Input.GetAxis("Vertical");

        Vector3 Movement=new Vector3(moveHorizontal,0,movevertical);
        rb.AddForce(Movement*speed);
    }

        private void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("COIN")){
            other.gameObject.SetActive(false);
            count=count+20;
            countText.text="Score: "+count.ToString();
            if(count>=500){
                winText.gameObject.SetActive(true);
            }
            }
            else if(other.gameObject.CompareTag("CUBE_COIN")){
            other.gameObject.SetActive(false);
            count=count+5;
            countText.text="Score: "+count.ToString();
            if(count>=500){
                winText.gameObject.SetActive(true);
            }
            }
            else if(other.gameObject.CompareTag("CAPSULE_COIN")){
            other.gameObject.SetActive(false);
            count=count+50;
            countText.text="Score: "+count.ToString();
            if(count>=500){
                winText.gameObject.SetActive(true);
            }
            }
        }
}

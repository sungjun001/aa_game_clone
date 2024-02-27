using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    private float moveSpeed = 10f;

    private bool isCrached = false;

    private bool isLaunched = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isCrached == false && isLaunched == true) {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;  
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {

        isCrached = true;
        if (other.gameObject.tag == "target") {
            
            GameObject childObject = transform.Find("Square").gameObject;
            // GameObject childObject = transform.GetChild(0).gameObject;

            SpriteRenderer childSprite =  childObject.GetComponent<SpriteRenderer>();

            childSprite.enabled = true;

            transform.SetParent(other.gameObject.transform);

            // GameManager.instance.DecreaseGoal();
        }   else if (other.gameObject.tag == "pin") {
            GameManager.instance.SetGameOver(false);
        }
    }

    public void Lunched() {
        isLaunched = true;
    }


}

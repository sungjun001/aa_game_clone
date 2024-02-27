using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCircleMove : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float rotateSpeed = -30f;  // 시계방향 (음수), 반시계방향 (양수)

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 원을 그리며 움직이게 
        if (GameManager.instance.isGameOver == false) {
            transform.Rotate(0,0,rotateSpeed * Time.deltaTime) ;
        }
        
    }
}


using UnityEngine;
using UnityEngine.UIElements;

public class Driver : MonoBehaviour
{
  [SerializeField] float steerSpeed = 20f;
  
  [SerializeField] float moveSpeed = 15f;
  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
    float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
    float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
    transform.Rotate(0, 0, -steerAmount);
    transform.Translate(0,moveAmount,0);

  }
}

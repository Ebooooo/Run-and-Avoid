using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour
{

    public LayerMask ground;
    public Transform groundedCheck;
    public bool isGrounded;
    public float jumpForce;
    public float speed;
    public float targetRotation;
    public float force;
    int jumpCount = 1;
    public int CurHp;
    Rigidbody2D rb;

 void Start(){
     rb = GetComponent<Rigidbody2D>();
     CurHp = 3;
 }

 void FixedUpdate(){
     rb.MoveRotation(Mathf.LerpAngle(rb.rotation, targetRotation, force * Time.fixedDeltaTime));
    if(isGrounded)
    {
        jumpCount = 1;
    }
    if (Input.GetMouseButtonDown(0) && jumpCount < 3){
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        jumpCount++;
        isGrounded  = false;
     }
     if(CurHp < 1)
     {
         Time.timeScale = 0f;
     }
 }

 public void Damage(int dmg){
     CurHp -= dmg;
     gameObject.GetComponent<Animation>().Play("HitAnimation");
 }

 void endScreen(){
     if (CurHp <= 0){
         Debug.Log("haha");
     }
 }

 public IEnumerator Knockback(float knockDuration, float knockbackPwr, Vector3 koncbackDir){
     float timer = 0;
     while(knockDuration > timer){
         timer += Time.deltaTime;
         rb.AddForce(new Vector3(koncbackDir.x * 10, koncbackDir.y + knockbackPwr * jumpForce, transform.position.z));
     }
     yield return 0;
 }
}

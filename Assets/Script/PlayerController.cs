using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public float minMoveableRange = 1f;
    public float maxMoveableRange = 100f;
    public float flap = 400f;
    public float outPosition = -7f;
    private Rigidbody2D m_Rigidbody2D;
    private bool isJump = true;

    void Start() {
        //コンポーネント読み込み
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 横移動の処理
        transform.Translate(Input.GetAxisRaw(
            "Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.position = new Vector2(Mathf.Clamp(
            transform.position.x, -minMoveableRange, maxMoveableRange),
            transform.position.y);
        // ジャンプの判定を行う
        if(Input.GetKeyDown(KeyCode.Space) && isJump) {
            Jump();
            isJump = false;
            Debug.Log("jump");
        }
        if (transform.position.y < outPosition)
        {
            Out();
        }
    }

    void Out() {
        Debug.Log("out");
    }

    void Goal() {
        Debug.Log("goal");
    }

    void Jump()
    {
        m_Rigidbody2D.AddForce(Vector2.up * flap);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            Goal();
        }
        if (other.gameObject.CompareTag("Groud"))
        {
            isJump = true;
        }
    }
}

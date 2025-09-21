using UnityEngine.InputSystem;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;

    void Start()
    {
        GameObject scoreG0 = GameObject.Find("ScoreCounter");
        scoreCounter = scoreG0 .GetComponent<ScoreCounter>();

    }


    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 Pos = this.transform.position;
        Pos.x = mousePos3D.x;
        this.transform.position = Pos;
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.CompareTag("Apple"))
        {
            Destroy(collidedWith);
            scoreCounter.score += 100;
            HighScore.TRY_SET_HIGH_SCORE(scoreCounter.score);
        }
        else
        {
            GameOver Go = FindFirstObjectByType<GameOver>();
            Go.SetGameOver();
        }
    }

}

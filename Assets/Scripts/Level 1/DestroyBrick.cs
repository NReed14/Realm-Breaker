using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBrick : MonoBehaviour
{
    public int numberOfHits = 0;
    public int maxHits;

    //public SpriteRenderer brickSprite;
    public float brickValue;
    public GameMaster gameMaster;
    public GameMaster2 gameMaster2;
    public GameMaster3 gameMaster3;
    public GameMaster4 gameMaster4;
    // Start is called before the first frame update
    void Start()
    {
        //brickSprite = GetComponent<SpriteRenderer>();
        gameMaster.GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        numberOfHits++;
        //brickSprite.color = Color.magenta;

        if (numberOfHits >= maxHits)
        {
            gameMaster.playerPoints = gameMaster.playerPoints + brickValue;
            gameMaster2.playerPoints = gameMaster2.playerPoints + brickValue;
            gameMaster3.playerPoints = gameMaster3.playerPoints + brickValue;
            gameMaster4.playerPoints = gameMaster4.playerPoints + brickValue;

            Destroy(this.gameObject);
        }


    }

}

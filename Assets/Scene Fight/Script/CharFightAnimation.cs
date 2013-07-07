using UnityEngine;
using System.Collections;

public class CharFightAnimation : MonoBehaviour
{
    public static int UP = 3;
    public static int DOWN = 0;
    public static int LEFT = 2;
    public static int RIGHT = 1;


    public bool isMoving = false;
    public int animationSpeed;


    private int direction;
    private int countAnimation;
    private int atualAnimation;


    void Start()
    {
        direction = 0;
        countAnimation = 0;
        atualAnimation = 0;

        Vector2 pt = new Vector2(0.05f, -0.1f * this.GetComponent<CharFightController>().character.sprite);
        renderer.material.SetTextureOffset("_MainTex", pt);
    }

    // Update is called once per frame
    void Update()
    {
        float num = 0;
        if (isMoving)
        {

            countAnimation++;
            if (countAnimation > animationSpeed)
            {
                atualAnimation++;
                if (atualAnimation >= 3)
                {
                    atualAnimation = 0;
                }
                countAnimation = 0;
            }

            num = 3 * direction + atualAnimation;

            Vector2 pt = new Vector2(0.05f * num, -0.1f * this.GetComponent<GameCharacterController>().character.sprite);

            renderer.material.SetTextureOffset("_MainTex", pt);

        }
        else
        {
            countAnimation = 0;
        }
    }

    public void moveUp()
    {
        direction = SpriteAnimation.UP;
        isMoving = true;
    }
    public void moveDown()
    {
        direction = SpriteAnimation.DOWN;
        isMoving = true;
    }
    public void moveLeft()
    {
        direction = SpriteAnimation.LEFT;
        isMoving = true;
    }
    public void moveRight()
    {
        direction = SpriteAnimation.RIGHT;
        isMoving = true;
    }
}


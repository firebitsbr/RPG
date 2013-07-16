using UnityEngine;
using System.Collections;

public class SpriteAnimation : MonoBehaviour
{
	public static int UP = 3;
	public static int DOWN = 0;
	public static int LEFT = 2;
	public static int RIGHT = 1;
	
	
	public bool hasAnim = false;
	public float animationSpeed;
    private SpriteAnim _currAnimation;
    private ArrayList _animation;
	
	
	private int countAnimation;
	private int atualAnimation;
	

	void Start ()
	{
		countAnimation = 0;
		atualAnimation = 0;

        Vector2 pt = new Vector2(0.05f, -0.1f * this.GetComponent<GameCharacterController>().character.sprite);
        renderer.material.SetTextureOffset("_MainTex", pt);

        _animation = new ArrayList();

        addAnimation("up",    new int[3] { 9,10,11 }, 5);
        addAnimation("down",  new int[3] { 0, 1, 2 }, 5);
        addAnimation("right", new int[3] { 3, 4, 5 }, 5);
        addAnimation("left",  new int[3] { 6, 7, 8 }, 5);
	}

    public void addAnimation(string name, int[] data, float speed)
    {
        for (var i = 0; i < _animation.Count; i++)
        {
            if (((SpriteAnim)_animation[i]).name == name)
            {
                _animation.RemoveAt(i);
            }
        }

        SpriteAnim anim = new SpriteAnim();
        anim.name = name;
        anim.data = data;
        anim.speed = speed;

        _animation.Add(anim);
    }

    public void playAnimation(string name)
    {
        for (var i = 0; i < _animation.Count; i++)
        {
            if (((SpriteAnim)_animation[i]).name == name)
            {
                _currAnimation = (SpriteAnim)_animation[i];
            }
        }
    }

    // Update is called once per frame
    void Update()
	{
		float num = 0;
        if (hasAnim)
        {
			countAnimation++;
			if(countAnimation > _currAnimation.speed) {
				atualAnimation++;
				if(atualAnimation >= _currAnimation.data.Length) {
					atualAnimation = 0;
				}
				countAnimation = 0;
			}

            num = _currAnimation.data[atualAnimation];
			
			Vector2 pt = new Vector2(0.05f * num, -0.1f * this.GetComponent<GameCharacterController>().character.sprite);

            renderer.material.SetTextureOffset("_MainTex", pt);
			
		} else {
			countAnimation = 0;
		}
	}
	
	public void moveUp() {
        hasAnim = true;
        this.playAnimation("up");
	}
	public void moveDown() {
        hasAnim = true;
        this.playAnimation("down");
	}
	public void moveLeft() {
        hasAnim = true;
        this.playAnimation("left");
	}
	public void moveRight() {
        hasAnim = true;
        this.playAnimation("right");
	}
}
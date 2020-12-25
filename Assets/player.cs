using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update

    public short level;
    public int health, armor;
    public float damage, critRate, critDmg;
    public int exp, expMax;

    Animator p_animator;

    void Start()
    {
        p_animator = gameObject.GetComponent<Animator>();
    }

    public void attack(/*GameObject enemy*/)
    {
        //enemy.hp -= dmg
    }

    public bool checkAlive(GameObject enemy)
    {
        ///if (enemy.hp > 0) return true;
        ///else return false;
        return true;
    }

    public void levelUp()
    {
        level++;
        health += 5;
        damage += 1;
        critRate += .05f;
        critDmg += .05f;

        //exp just hit 1200, you needed 1k total for next level, means current exp towards next level = 200 (exp - expMax)
        //cast expmax as int so only whole numbers as exp value
        exp -= expMax;
        expMax = (int)(expMax * 1.2f);
    }

    public void gainExp(int experience)
    {
        exp += experience;
        if (exp > expMax)
        {
            levelUp();
        }
    }

    public void equipWeapon(int stat /* gameobejct to equip, then going through and adding what needs to be added from it, store current equipped weapon somewhere*/ )
    {
        ///to do
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            attack();
            p_animator.SetTrigger("Attack");
        }
    }
}

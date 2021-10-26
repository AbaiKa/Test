using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonePlayerCharacter : MonoBehaviour
{
    public void NonePlayerCharacter_Move(Transform gameObjectPosition, float speed)
    {
        transform.position = Vector2.MoveTowards(transform.position,
            gameObjectPosition.position, speed * Time.deltaTime
            );

        if (gameObject.transform.position == gameObjectPosition.transform.position) // Если NPC на месте прекращаем движение
            NPC._isSwap = false;
    }

    public void NonePlayerCharacter_Animation(Animator animator, string nameAnimation)
    {
        animator.Play(nameAnimation);
    }
}

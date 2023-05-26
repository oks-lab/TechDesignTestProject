using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<Animator>().SetTrigger("click_trigger");
    }
}

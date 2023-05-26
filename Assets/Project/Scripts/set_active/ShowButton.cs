using UnityEngine;

public class ShowButton : MonoBehaviour
{
    [SerializeField] GameObject m_Button;

    void OnMouseDown()
    {
        m_Button.SetActive(true) ;
    }
}

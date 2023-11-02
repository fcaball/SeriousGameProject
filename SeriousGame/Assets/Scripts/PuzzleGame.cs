using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;

public class PuzzleGame : MonoBehaviour
{
    public Image hg;
    public Image hd;
    public Image bg;
    public Image bd;

    //public Camera cam;
    private RaycastHit hit;

    GraphicRaycaster m_Raycaster;
    PointerEventData m_PointerEventData;
    EventSystem m_EventSystem;

    GameObject first_hit = null;
    GameObject second_hit = null;

    private bool found;
    private Vector3 hg_pos;
    private Vector3 hd_pos;
    private Vector3 bg_pos;
    private Vector3 bd_pos;

    void Start()
    {
        m_Raycaster = GetComponent<GraphicRaycaster>();
        m_EventSystem = GetComponent<EventSystem>();

        found = false;
        hd_pos = hg.transform.position;
        bd_pos = bd.transform.position;
        hg_pos = bg.transform.position;
        bg_pos = hd.transform.position;
    }

    void Update()
    {

        if(first_hit != null && found == false)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                m_PointerEventData = new PointerEventData(m_EventSystem);
                m_PointerEventData.position = Input.mousePosition;

                List<RaycastResult> results = new List<RaycastResult>();

                m_Raycaster.Raycast(m_PointerEventData, results);
                
                second_hit = results[0].gameObject;

                Swap(first_hit, second_hit);

                first_hit = null;
                second_hit = null;

            }

        }

        Check();


        if (Input.GetKey(KeyCode.Mouse0) && found == false)
        {
            m_PointerEventData = new PointerEventData(m_EventSystem);
            m_PointerEventData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();

            m_Raycaster.Raycast(m_PointerEventData, results);

            first_hit = results[0].gameObject;
        }

    }


    private void Swap(GameObject obj1, GameObject obj2)
    {
        Vector2 tmp;

        tmp = obj1.transform.position;
        obj1.transform.position = obj2.transform.position;
        obj2.transform.position = tmp;
    }

    private void Check()
    {

        bool cond1 = hg.transform.position.x >= hg_pos.x - 1 && hg.transform.position.x <= hg_pos.x + 1 && hg.transform.position.y >= hg_pos.y - 1 && hg.transform.position.y <= hg_pos.y + 1;
        bool cond2 = hd.transform.position.x >= hd_pos.x - 1 && hd.transform.position.x <= hd_pos.x + 1 && hd.transform.position.y >= hd_pos.y - 1 && hd.transform.position.y <= hd_pos.y + 1;
        bool cond3 = bg.transform.position.x >= bg_pos.x - 1 && bg.transform.position.x <= bg_pos.x + 1 && bg.transform.position.y >= bg_pos.y - 1 && bg.transform.position.y <= bg_pos.y + 1;
        bool cond4 = bd.transform.position.x >= bd_pos.x - 1 && bd.transform.position.x <= bd_pos.x + 1 && bd.transform.position.y >= bd_pos.y - 1 && bd.transform.position.y <= bd_pos.y + 1;

        if (cond1 && cond2 && cond3 && cond4)
        {
            found = true;
            StartCoroutine(DisableImages());
        }
    }

    IEnumerator DisableImages()
    {
        yield return new WaitForSeconds(2f);
        hg.gameObject.SetActive(false);
        hd.gameObject.SetActive(false);
        bg.gameObject.SetActive(false);
        bd.gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JigsawScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pickUpText;

    [SerializeField]
    private GameObject Greenportal;

    public GameObject jigsawPanel;

    private bool pickUpAllowed;

    public RunningTimer timer;

    public Button button;

    public bool isClicked = false;

    // Use this for initialization
    void Start()
    {
        jigsawPanel.GetComponent<CanvasRenderer>().transform.localScale = Vector2.zero;
        //jigsawPanel.SetActive(false);
        pickUpText.SetActive(false);
        Greenportal.SetActive(false);

        
    }

    // Update is called once per frame
    private void Update()
    {
        

        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
            timer.isPicked = true;
            jigsawPanel.GetComponent<CanvasRenderer>().transform.LeanScale(Vector2.one, 0.8f);

            Button btn = button.GetComponent<Button>();
            btn.onClick.AddListener(ClickTask);

        }
            
    }
    void ClickTask()
    {
        if (isClicked == false)
        {
            Debug.Log("PEKPEK");
            jigsawPanel.GetComponent<CanvasRenderer>().transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            
            pickUpText.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        Greenportal.SetActive(true);
        Destroy(gameObject);
    }

    
}

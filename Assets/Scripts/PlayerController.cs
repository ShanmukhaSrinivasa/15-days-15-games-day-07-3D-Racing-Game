using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera hoodCamera;
    [SerializeField] private KeyCode switchKey;

    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] private int inputId;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
        
    }

    private void LateUpdate()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal" + inputId);
        forwardInput = Input.GetAxisRaw("Vertical" + inputId);

        //Moves the car based on vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotates the car based on Horizontal Input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FinishLine")
        {
            Time.timeScale = 0;

            if (this.gameObject.tag == "Player1")
            {
                GameManager.instance.ShowCG(GameManager.instance.player1WinCG);
                GameManager.instance.HideCG(GameManager.instance.gameCG);
            }
            else if (this.gameObject.tag == "Player2")
            {
                GameManager.instance.ShowCG(GameManager.instance.player2WinCG);
                GameManager.instance.HideCG(GameManager.instance.gameCG);
            }
        }

        if (other.gameObject.tag == "GameOver")
        {
            Time.timeScale = 0;

            if (this.gameObject.tag == "Player1")
            {
                GameManager.instance.ShowCG(GameManager.instance.player2WinCG);
                GameManager.instance.HideCG(GameManager.instance.gameCG);
            }
            else if (this.gameObject.tag == "Player2")
            {
                GameManager.instance.ShowCG(GameManager.instance.player1WinCG);
                GameManager.instance.HideCG(GameManager.instance.gameCG);
            }
        }
    }
}

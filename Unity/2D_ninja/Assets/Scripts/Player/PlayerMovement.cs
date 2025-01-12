using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Config")]
    [SerializedField] private float speed;

    private PlayerActions actions;

    private void Awak()
    {
        actions = new PlayerActions();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()  //Unity method that is called when the script is enabled
    {
        actions.Enable();
    }

    private void OnDisable()
    {
        actions.Disable();
    }
}

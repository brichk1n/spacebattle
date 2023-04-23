using UnityEngine;

public class PlayerInput
{
    private Vector3 playerInputVector;
    private float horizontalInput;
    private float verticalInput;

    private void Start()
    {

    }

    private void Update()
    {
        ReadInput();
        InputToVector();
    }

    private void ReadInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void InputToVector()
    {
        playerInputVector = new Vector3(horizontalInput, verticalInput, 0f);
    }

    public Vector3 GetInputVector()
    {
        return playerInputVector;
    }
}

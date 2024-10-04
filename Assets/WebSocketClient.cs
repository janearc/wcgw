using UnityEngine;
using WebSocketSharp;

public class WebSocketClient : MonoBehaviour
{
    private WebSocket ws;

    void Start()
    {
        // Initialize WebSocket
        ws = new WebSocket("ws://localhost:8080"); // Adjust URL to match your backend

        // Set up WebSocket events
        ws.OnMessage += (sender, e) => {
            Debug.Log("Received from server: " + e.Data);
            // Call a method to handle the procedural data
            HandleServerData(e.Data);
        };

        // Connect to the WebSocket server
        ws.Connect();
    }

    void OnDestroy()
    {
        // Clean up
        if (ws != null)
        {
            ws.Close();
        }
    }

    void HandleServerData(string data)
    {
        // Use JSON parsing to create or modify objects based on data
        // For now, let's just log it
        Debug.Log("Handling data: " + data);
    }
}
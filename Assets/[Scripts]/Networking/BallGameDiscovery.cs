using System.Collections.Generic;
using System.Net;
using Mirage;
using Mirage.Discovery;
using UnityEngine;

public class BallGameDiscovery : LanDiscoveryBase<DiscoveryRequest, DiscoveryResponse>
{
    public NetworkManager networkManager;
    
    protected override DiscoveryResponse ProcessClientRequest(DiscoveryRequest request, IPEndPoint endpoint)
    {
        Debug.Log($"Received request from {endpoint.Address}.");
        
        return new DiscoveryResponse()
        {
            
        };
    }

    protected override DiscoveryRequest CraftDiscoveryRequest()
    {
        Debug.Log("Crafting discovery request...");
        
        return new DiscoveryRequest()
        {
            
        };
    }

    protected override void ProcessServerResponse(DiscoveryResponse response, IPEndPoint endpoint)
    {
        Debug.Log($"Discovered server at {endpoint.Address}!");
        
        StopDiscovery();
        networkManager.Client.Connect(endpoint.Address.ToString());
    }
}

[NetworkMessage]
public struct DiscoveryRequest
{
    
}

[NetworkMessage]
public struct DiscoveryResponse
{
    
}

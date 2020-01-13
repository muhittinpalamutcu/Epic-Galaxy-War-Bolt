using System;
using UdpKit;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : Bolt.GlobalEventListener
{
    public void StartServer()
    {
        BoltLauncher.StartServer();
    }

    public void StartClient()
    {
        BoltLauncher.StartClient();
    }

    //Create Host Game Room
    public override void BoltStartDone()
    {
        if (BoltNetwork.IsServer)
        {
            string matchName = "Test Match";
            BoltNetwork.SetServerInfo(matchName, null);
            BoltNetwork.LoadScene("SampleScene");


        }
    }

    //For join Room
    public override void SessionListUpdated(Map<Guid, UdpSession> sessionList)
    {
        //This sessionlist will is Photon Stuff so all the sessionlist goes to photon server 
        // basically loops through all the sessionlist 
        foreach (var session in sessionList)
        {
            UdpSession photonSession = session.Value as UdpSession;
            if (photonSession.Source == UdpSessionSource.Photon)
            {
                BoltNetwork.Connect(photonSession);
            }

        }

    }
}

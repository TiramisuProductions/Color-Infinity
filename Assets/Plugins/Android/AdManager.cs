using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;

public class AdManager : MonoBehaviour
{

    public static AdManager Instance { set; get; }


    // Use this for initialization
    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

		Admob.Instance().initAdmob("ca-app-pub-6498383909292734/7431721209", "ca-app-pub-6498383909292734/8908454401");
       Admob.Instance().setTesting(true);
        Admob.Instance().loadInterstitial();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public bool isvideoadready()
    {
      return   Admob.Instance().isInterstitialReady();
    }

    public void ShowBanner()
    {
        Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.TOP_CENTER, 5);
    }

    public void showVideo()
    {
        Admob.Instance().showInterstitial();
    }

    public void hideBanner()
    {
        Admob.Instance().removeBanner();
    }





    
}

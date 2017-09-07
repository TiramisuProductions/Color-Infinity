using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notification : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Enable line below to enable logging if you are having issues setting up OneSignal. (logLevel, visualLogLevel)
		// OneSignal.SetLogLevel(OneSignal.LOG_LEVEL.INFO, OneSignal.LOG_LEVEL.INFO);

		OneSignal.StartInit("a176f267-d66f-4475-9c23-e85b5b0a9f0a")

			.HandleNotificationOpened(HandleNotificationOpened)
			.InFocusDisplaying(OneSignal.OSInFocusDisplayOption.Notification)
			.EndInit();
		

		// Call syncHashedEmail anywhere in your app if you have the user's email.
		// This improves the effectiveness of OneSignal's "best-time" notification scheduling feature.
		// OneSignal.syncHashedEmail(userEmail);
	}

	// Gets called when the player opens the notification.
	private static void HandleNotificationOpened(OSNotificationOpenedResult result) {
	}
}

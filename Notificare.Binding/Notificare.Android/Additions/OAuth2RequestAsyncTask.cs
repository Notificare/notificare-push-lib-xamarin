﻿using Android.Runtime;
using System;

namespace Notificare.Android.OAuth2
{
	public partial class OAuth2RequestAsyncTask : global::Android.OS.AsyncTask
	{
		protected override Java.Lang.Object DoInBackground (params Java.Lang.Object[] @params)
		{
			return new Java.Lang.Object (JNIEnv.CallObjectMethod (Handle, JNIEnv.GetMethodID (JNIEnv.GetObjectClass (Handle), "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
		}
	}
}


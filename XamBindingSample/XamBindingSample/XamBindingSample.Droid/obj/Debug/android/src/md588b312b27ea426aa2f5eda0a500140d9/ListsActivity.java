package md588b312b27ea426aa2f5eda0a500140d9;


public class ListsActivity
	extends md55e01038d7640b0d4dbbb8416c21f5b0f.ActivityBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("XamBindingSample.ListsActivity, XamBindingSample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ListsActivity.class, __md_methods);
	}


	public ListsActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ListsActivity.class)
			mono.android.TypeManager.Activate ("XamBindingSample.ListsActivity, XamBindingSample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

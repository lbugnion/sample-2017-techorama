package md576f434d88f7f5a44021073d4644b577c;


public class CachingViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("GalaSoft.MvvmLight.Helpers.CachingViewHolder, GalaSoft.MvvmLight.Platform.AndroidSupport, Version=5.3.0.19094, Culture=neutral, PublicKeyToken=null", CachingViewHolder.class, __md_methods);
	}


	public CachingViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == CachingViewHolder.class)
			mono.android.TypeManager.Activate ("GalaSoft.MvvmLight.Helpers.CachingViewHolder, GalaSoft.MvvmLight.Platform.AndroidSupport, Version=5.3.0.19094, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

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

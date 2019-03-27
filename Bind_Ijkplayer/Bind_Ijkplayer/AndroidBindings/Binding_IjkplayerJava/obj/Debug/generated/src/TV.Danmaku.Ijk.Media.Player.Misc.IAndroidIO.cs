using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Misc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IAndroidIO']"
	[Register ("tv/danmaku/ijk/media/player/misc/IAndroidIO", "", "TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIOInvoker")]
	public partial interface IAndroidIO : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IAndroidIO']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()I", "GetCloseHandler:TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIOInvoker, Binding_IjkplayerJava")]
		int Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IAndroidIO']/method[@name='open' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("open", "(Ljava/lang/String;)I", "GetOpen_Ljava_lang_String_Handler:TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIOInvoker, Binding_IjkplayerJava")]
		int Open (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IAndroidIO']/method[@name='read' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("read", "([BI)I", "GetRead_arrayBIHandler:TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIOInvoker, Binding_IjkplayerJava")]
		int Read (byte[] p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IAndroidIO']/method[@name='seek' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("seek", "(JI)J", "GetSeek_JIHandler:TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIOInvoker, Binding_IjkplayerJava")]
		long Seek (long p0, int p1);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/misc/IAndroidIO", DoNotGenerateAcw=true)]
	internal class IAndroidIOInvoker : global::Java.Lang.Object, IAndroidIO {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/misc/IAndroidIO");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAndroidIOInvoker); }
		}

		IntPtr class_ref;

		public static IAndroidIO GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAndroidIO> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.misc.IAndroidIO"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAndroidIOInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Close);
			return cb_close;
		}

		static int n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIO __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe int Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_open_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_Handler ()
		{
			if (cb_open_Ljava_lang_String_ == null)
				cb_open_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Open_Ljava_lang_String_);
			return cb_open_Ljava_lang_String_;
		}

		static int n_Open_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIO __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Open (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_open_Ljava_lang_String_;
		public unsafe int Open (string p0)
		{
			if (id_open_Ljava_lang_String_ == IntPtr.Zero)
				id_open_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_open_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_read_arrayBI;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIHandler ()
		{
			if (cb_read_arrayBI == null)
				cb_read_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Read_arrayBI);
			return cb_read_arrayBI;
		}

		static int n_Read_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIO __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayBI;
		public unsafe int Read (byte[] p0, int p1)
		{
			if (id_read_arrayBI == IntPtr.Zero)
				id_read_arrayBI = JNIEnv.GetMethodID (class_ref, "read", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_seek_JI;
#pragma warning disable 0169
		static Delegate GetSeek_JIHandler ()
		{
			if (cb_seek_JI == null)
				cb_seek_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, long>) n_Seek_JI);
			return cb_seek_JI;
		}

		static long n_Seek_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIO __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Seek (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_seek_JI;
		public unsafe long Seek (long p0, int p1)
		{
			if (id_seek_JI == IntPtr.Zero)
				id_seek_JI = JNIEnv.GetMethodID (class_ref, "seek", "(JI)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_seek_JI, __args);
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Misc {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidMediaFormat']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/misc/AndroidMediaFormat", DoNotGenerateAcw=true)]
	public partial class AndroidMediaFormat : global::Java.Lang.Object, global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat {


		public static class InterfaceConsts {

			// The following are fields from: tv.danmaku.ijk.media.player.misc.IMediaFormat

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaFormat']/field[@name='KEY_HEIGHT']"
			[Register ("KEY_HEIGHT")]
			public const string KeyHeight = (string) "height";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaFormat']/field[@name='KEY_MIME']"
			[Register ("KEY_MIME")]
			public const string KeyMime = (string) "mime";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaFormat']/field[@name='KEY_WIDTH']"
			[Register ("KEY_WIDTH")]
			public const string KeyWidth = (string) "width";
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/misc/AndroidMediaFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidMediaFormat); }
		}

		protected AndroidMediaFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_media_MediaFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidMediaFormat']/constructor[@name='AndroidMediaFormat' and count(parameter)=1 and parameter[1][@type='android.media.MediaFormat']]"
		[Register (".ctor", "(Landroid/media/MediaFormat;)V", "")]
		public unsafe AndroidMediaFormat (global::Android.Media.MediaFormat p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AndroidMediaFormat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/media/MediaFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/media/MediaFormat;)V", __args);
					return;
				}

				if (id_ctor_Landroid_media_MediaFormat_ == IntPtr.Zero)
					id_ctor_Landroid_media_MediaFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/media/MediaFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_media_MediaFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_media_MediaFormat_, __args);
			} finally {
			}
		}

		static Delegate cb_getInteger_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInteger_Ljava_lang_String_Handler ()
		{
			if (cb_getInteger_Ljava_lang_String_ == null)
				cb_getInteger_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetInteger_Ljava_lang_String_);
			return cb_getInteger_Ljava_lang_String_;
		}

		static int n_GetInteger_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidMediaFormat __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidMediaFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInteger (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInteger_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidMediaFormat']/method[@name='getInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInteger", "(Ljava/lang/String;)I", "GetGetInteger_Ljava_lang_String_Handler")]
		public virtual unsafe int GetInteger (string p0)
		{
			if (id_getInteger_Ljava_lang_String_ == IntPtr.Zero)
				id_getInteger_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInteger", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInteger_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInteger", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidMediaFormat __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidMediaFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidMediaFormat']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

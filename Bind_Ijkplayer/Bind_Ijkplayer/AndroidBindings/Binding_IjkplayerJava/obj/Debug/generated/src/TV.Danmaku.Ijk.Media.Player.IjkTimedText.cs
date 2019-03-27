using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkTimedText']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IjkTimedText", DoNotGenerateAcw=true)]
	public sealed partial class IjkTimedText : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IjkTimedText", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IjkTimedText); }
		}

		internal IjkTimedText (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Rect_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkTimedText']/constructor[@name='IjkTimedText' and count(parameter)=2 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/graphics/Rect;Ljava/lang/String;)V", "")]
		public unsafe IjkTimedText (global::Android.Graphics.Rect p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (IjkTimedText)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/graphics/Rect;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/Rect;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Rect_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_Rect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Rect;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Rect_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_Rect_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getBounds;
		public unsafe global::Android.Graphics.Rect Bounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkTimedText']/method[@name='getBounds' and count(parameter)=0]"
			[Register ("getBounds", "()Landroid/graphics/Rect;", "GetGetBoundsHandler")]
			get {
				if (id_getBounds == IntPtr.Zero)
					id_getBounds = JNIEnv.GetMethodID (class_ref, "getBounds", "()Landroid/graphics/Rect;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBounds), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getText;
		public unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkTimedText']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

using System.Drawing;
using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace FLAnimatedImageBinding {

	[BaseType (typeof (NSObject))]
	public partial interface FLAnimatedImage {

		[Export ("posterImage", ArgumentSemantic.Retain)]
		UIImage PosterImage { get; }

		[Export ("size", ArgumentSemantic.Assign)]
		SizeF Size { get; }

		[Export ("loopCount")]
		uint LoopCount { get; }

		[Export ("delayTimes", ArgumentSemantic.Retain)]
		NSObject [] DelayTimes { get; }

		[Export ("frameCount")]
		uint FrameCount { get; }

		[Export ("frameCacheSizeCurrent")]
		uint FrameCacheSizeCurrent { get; }

		[Export ("frameCacheSizeMax")]
		uint FrameCacheSizeMax { get; set; }

		[Export ("imageLazilyCachedAtIndex:")]
		UIImage ImageLazilyCachedAtIndex (uint index);

		[Static, Export ("sizeForImage:")]
		SizeF SizeForImage (NSObject image);

		[Export ("initWithAnimatedGIFData:")]
		IntPtr Constructor (NSData data);

		[Export ("data", ArgumentSemantic.Retain)]
		NSData Data { get; }
	}

	[BaseType (typeof (UIImageView))]
	public partial interface FLAnimatedImageView {

		[Export ("animatedImage", ArgumentSemantic.Retain)]
		FLAnimatedImage AnimatedImage { get; set; }

		[Export ("currentFrame", ArgumentSemantic.Retain)]
		UIImage CurrentFrame { get; }

		[Export ("currentFrameIndex")]
		uint CurrentFrameIndex { get; }
	}
}

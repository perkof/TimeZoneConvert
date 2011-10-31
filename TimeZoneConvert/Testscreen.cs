using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TimeZoneConvert
{
	public partial class Testscreen : UIViewController
	{
		//loads the Testscreen.xib file and connects it to this object
		public Testscreen () : base ("Testscreen", null)
		{

		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			this.ExceptionLabel.Text = "Nothing has happened";
			
			var timezone = TimeZoneInfo.FindSystemTimeZoneById("Australia/Sydney");
			var time = DateTime.Now;
			
			try{
				var newTime = TimeZoneInfo.ConvertTime(time, timezone);
				
			}catch (Exception e){
				this.ExceptionLabel.Text = e.Message;
			}
		}
	}
}

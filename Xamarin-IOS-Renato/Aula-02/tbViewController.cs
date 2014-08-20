using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using System.Drawing;
using System.Collections.Generic;

namespace Aula02
{
	public partial class tbViewController : UITableViewController
	{
		public tbViewController (IntPtr handle) : base (handle)
		{
		}

//		public override void DidReceiveMemoryWarning ()
//		{
//			// Releases the view if it doesn't have a superview.
//			base.DidReceiveMemoryWarning ();
//
//			// Release any cached data, images, etc that aren't in use.
//		}

		protected TableSource tableSource;

		#region Constructors

		[Export("initWithCoder:")]
		public tbViewController (NSCoder coder) : base(coder)
		{
		}

		/// <summary>
		/// You specify the table style in the constructor when using a UITableViewController
		/// </summary>
		public tbViewController (UITableViewStyle tableStyle) : base (tableStyle)
		{
		}

		#endregion




		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			if(TableView.Style == UITableViewStyle.Grouped)
				Title = "Grouped Table";
			else if (TableView.Style == UITableViewStyle.Plain)
				Title = "Plain Table";

			CreateTableItems ();
			TableView.Source = tableSource;

		}
		public void CreateTableItems ()
		{
			List<TableItemGroup> tableItems = new List<TableItemGroup> ();

			// declare vars
			TableItemGroup tGroup;

			// Section 1
			tGroup = new TableItemGroup() { Name = "Section 1 Header", Footer = "Section 1 Footer" };
			tGroup.Items.Add (new TableItem("Row 0"));
			tableItems.Add (tGroup);

			// Section 2
			tGroup = new TableItemGroup() { Name = "Section 2 Header", Footer = "Section 2 Footer" };
			tGroup.Items.Add (new TableItem("Row 0"));
			tGroup.Items.Add (new TableItem("Row 1"));
			tableItems.Add (tGroup);

			// Section 3
			tGroup = new TableItemGroup() { Name = "Section 3 Header", Footer = "Section 3 Footer" };
			tGroup.Items.Add (new TableItem("Row 0"));
			tGroup.Items.Add (new TableItem("Row 1"));
			tGroup.Items.Add (new TableItem("Row 2"));
			tableItems.Add (tGroup);

			// Section 4
			tGroup = new TableItemGroup() { Name = "Section 4 Header", Footer = "Section 4 Footer" };
			tGroup.Items.Add (new TableItem("Row 0"));
			tGroup.Items.Add (new TableItem("Row 1"));
			tGroup.Items.Add (new TableItem("Row 2"));
			tGroup.Items.Add (new TableItem("Row 3"));
			tableItems.Add (tGroup);


			// Section 5
			tGroup = new TableItemGroup() { Name = "Section 5 Header", Footer = "Section 5 Footer" };
			tGroup.Items.Add (new TableItem("Row 0"));
			tGroup.Items.Add (new TableItem("Row 1"));
			tGroup.Items.Add (new TableItem("Row 2"));
			tGroup.Items.Add (new TableItem("Row 3"));
			tGroup.Items.Add (new TableItem("Row 4"));
			tableItems.Add (tGroup);

			// For custom cells, comment out the first and uncomment the second.
			tableSource = new TableSource (tableItems);
		}
	}
}

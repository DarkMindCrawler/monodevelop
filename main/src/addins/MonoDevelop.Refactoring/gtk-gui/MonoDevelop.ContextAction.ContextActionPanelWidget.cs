
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.ContextAction
{
	public partial class ContextActionPanelWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Label label1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewContextActions;
		private global::Gtk.Label labelDescription;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.ContextAction.ContextActionPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.ContextAction.ContextActionPanelWidget";
			// Container child MonoDevelop.ContextAction.ContextActionPanelWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("_Available context actions:");
			this.label1.UseUnderline = true;
			this.vbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewContextActions = new global::Gtk.TreeView ();
			this.treeviewContextActions.CanFocus = true;
			this.treeviewContextActions.Name = "treeviewContextActions";
			this.GtkScrolledWindow.Add (this.treeviewContextActions);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w3.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelDescription = new global::Gtk.Label ();
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Xalign = 0F;
			this.vbox1.Add (this.labelDescription);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelDescription]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}

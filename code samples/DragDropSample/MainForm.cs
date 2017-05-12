using System.Globalization;
using System.Windows.Forms;

namespace DragDropSample
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// This constant is used when checking for the CTRL key during drop operations.
		/// This makes the code more readable for future maintenance.
		/// </summary>
		private const int CtrlKey = 8;

		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// The MouseDown event of the source control is used to initiate a drag operation.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A MouseEventArgs that contains the event data.</param>
		private void tbText_MouseDown(object sender, MouseEventArgs e)
		{
			// This initiates a DragDrop operation, specifying that the data to be dragged
			// with be the text stored in the tbText control.
			tbText.DoDragDrop(tbText.Text, DragDropEffects.Copy);
		}

		/// <summary>
		/// The MouseDown event of the source control is used to initiate a drag operation.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A MouseEventArgs that contains the event data.</param>
		private void numericUpDown_MouseDown(object sender, MouseEventArgs e)
		{
			// This initiates a DragDrop operation, specifying that the data to be dragged
			// with be the value stored in the numericUpDown control.
			numericUpDown.DoDragDrop(
				numericUpDown.Value.ToString(CultureInfo.InvariantCulture), 
				DragDropEffects.Copy);
		}

		/// <summary>
		/// The MouseDown event of the source control is used to initiate a drag operation.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A MouseEventArgs that contains the event data.</param>
		private void dateTimePicker_MouseDown(object sender, MouseEventArgs e)
		{
			// This initiates a DragDrop operation, specifying that the data to be dragged
			// with be the value stored in the dateTimePicker control.
			dateTimePicker.DoDragDrop(
				dateTimePicker.Value.ToString(CultureInfo.InvariantCulture), 
				DragDropEffects.Copy);
		}

		/// <summary>
		/// The DragEnter event of the target control fires when the mouse enters
		/// a target control during a drag operation, and is used to determine if a drop
		/// will be allowed over this control.  This generally involves checking the type 
		/// of data being dragged, the type of effects allowed (copy, move, etc.), 
		/// and potentially the type and/or the specific instance of the source control that 
		/// initiated the drag operation.
		/// 
		/// This event will fire only if the AllowDrop property of the target control has
		/// been set to true.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A DragEventArgs that contains the event data.</param>
		private void listBox_DragEnter(object sender, DragEventArgs e)
		{
			// Display some information about the DragDrop information in the
			// richTextBox control to show some of the information available.
			richTextBox.Text = "Allowed Effect: " + e.AllowedEffect +
			"\r\nAvailable Formats:\r\n";

			// Data may be available in more than one format, so loop through
			// all available formats and display them in richTextBox.
			foreach (string availableFormat in e.Data.GetFormats(true))
			{
				richTextBox.Text += "\t" + availableFormat + "\r\n";
			}

			// This control will use any dropped data to add items to the listbox.
			// Therefore, only data in a text format will be allowed.  Setting the 
			// autoConvert parameter to true specifies that any data that can be
			// converted to a text format is also acceptable.
			if (e.Data.GetDataPresent(DataFormats.Text, true))
			{
				// Some controls in this sample allow both Copy and Move effects.
				// If a Move effect is allowed, this implementation assumes a Move 
				// effect unless the CTRL key was pressed, in which case a Copy
				// effect is assumed.  This follows standard DragDrop conventions.
				if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move && (e.KeyState & CtrlKey) != CtrlKey)
				{
					// Show the standard Move icon.
					e.Effect = DragDropEffects.Move;
				}
				else
				{
					// Show the standard Copy icon.
					e.Effect = DragDropEffects.Copy;
				}
			}
		}

		/// <summary>
		/// The DragDrop event of the target control fires when a drop actually occurs over
		/// the target control.  This is where the data being dragged is actually processed.
		/// 
		/// This event will fire only if the AllowDrop property of the target control has
		/// been set to true.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A DragEventArgs that contains the event data.</param>
		private void listBox_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text, true))
			{
				// Create the list item using the data provided by the source control.
				listBox.Items.Add(e.Data.GetData(DataFormats.Text));
			}
		}
	}
}

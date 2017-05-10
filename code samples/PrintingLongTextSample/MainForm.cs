using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrintingSample
{
	public partial class MainForm : Form
	{
		#region Attributes
		//A very long text
		private const string LongText = @"Lincoln's Gettysburg Address (November 19, 1863)

	Four score and seven years ago our fathers brought forth on this continent a new nation, conceived in liberty and dedicated to the proposition that all men are created equal.

	Now we are engaged in a great civil war, testing whether that nation or any nation so conceived and so dedicated can long endure. We are met on a great battlefield of that war. We have come to dedicate a portion of that field as a final resting-place for those who here gave their lives that that nation might live.It is altogether fitting and proper that we should do this.

	But in a larger sense, we cannot dedicate, we cannot consecrate, we cannot hallow this ground.The brave men, living and dead who struggled here have consecrated it far above our poor power to add or detract. The world will little note nor long remember what we say here, but it can never forget what they did here.It is for us the living rather to be dedicated here to the unfinished work which they who fought here have thus far so nobly advanced.It is rather for us to be here dedicated to the great task remaining before us--that from these honored dead we take increased devotion to that cause for which they gave the last full measure of devotion--that we here highly resolve that these dead shall not have died in vain, that this nation under God shall have a new birth of freedom, and that government of the people, by the people, for the people shall not perish from the earth.";

		// Declare a variable to hold the position of the last printed char.
		private int _currentCharIndex;
		#endregion

		public MainForm()
		{
			InitializeComponent();
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			txtDocument.Text = LongText;
		}

		/// <summary>
		/// The PrintPreviewDialog is associated with the PrintDocument as the preview is 
		/// rendered, the PrintPage event is triggered. This event is passed a graphics 
		/// context where it "draws" the page.
		/// </summary>
		private void btnPrintPreview_Click(object sender, EventArgs e)
		{
			try
			{
				printPreviewDialog.Document = printDocument;
				printPreviewDialog.ShowDialog();
			}
			catch (Exception)
			{
				MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
			}
		}
		
		/// <summary>
		/// The PrintDialog allows the user to select the printer that they want to print 
		/// to, as well as other printing options.
		/// </summary>
		private void btnPrintDialog_Click(object sender, EventArgs e)
		{
			printDialog.Document = printDocument;
			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				printDocument.Print();
			}
		}

		/// <summary>
		/// Page setup lets you specify things like the paper size, portrait, 
		/// landscape, etc.
		/// </summary>
		private void btnPageSetup_Click(object sender, EventArgs e)
		{
			pageSetupDialog.Document = printDocument;
			pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

			if (pageSetupDialog.ShowDialog() == DialogResult.OK)
			{
				printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
			}
		}

		private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
			_currentCharIndex = 0;
		}

		/// <summary>
		/// PrintPage is the printing event. This event gets fired for every 
		/// page that will be printed. You could also handle the BeginPrint and EndPrint
		/// events for more control.
		/// 
		/// The following is very 
		/// fast and useful for plain text as MeasureString calculates the text that
		/// can be fitted on an entire page. This is not that useful, however, for 
		/// formatted text. In that case you would want to have word-level (vs page-level)
		/// control, which is more complicated.
		/// </summary>
		private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			// Initialize the font to be used for printing.
			Font font = new Font("Microsoft Sans Serif", 24);

			var pageSettings = printDocument.DefaultPageSettings;
			// Initialize local variables that contain the bounds of the printing 
			// area rectangle.
			var intPrintAreaHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
			var intPrintAreaWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;

			// Initialize local variables to hold margin values that will serve
			// as the X and Y coordinates for the upper left corner of the printing 
			// area rectangle.
			var marginLeft = pageSettings.Margins.Left;
			// X coordinate
			var marginTop = pageSettings.Margins.Top;
			// Y coordinate

			// If the user selected Landscape mode, swap the printing area height 
			// and width.
			if (printDocument.DefaultPageSettings.Landscape)
			{
				var intTemp = intPrintAreaHeight;
				intPrintAreaHeight = intPrintAreaWidth;
				intPrintAreaWidth = intTemp;
			}

			// Calculate the total number of lines in the document based on the height of
			// the printing area and the height of the font.
			// Initialize the rectangle structure that defines the printing area.
			RectangleF rectPrintingArea = new RectangleF(marginLeft, marginTop, intPrintAreaWidth, intPrintAreaHeight);

			// Instantiate the StringFormat class, which encapsulates text layout 
			// information (such as alignment and line spacing), display manipulations 
			// (such as ellipsis insertion and national digit substitution) and OpenType 
			// features. Use of StringFormat causes MeasureString and DrawString to use
			// only an integer number of lines when printing each page, ignoring partial
			// lines that would otherwise likely be printed if the number of lines per 
			// page do not divide up cleanly for each page (which is usually the case).
			// See further discussion in the SDK documentation about StringFormatFlags.
			StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
			// Call MeasureString to determine the number of characters that will fit in
			// the printing area rectangle. The CharFitted Int32 is passed ByRef and used
			// later when calculating intCurrentChar and thus HasMorePages. LinesFilled 
			// is not needed for this sample but must be passed when passing CharsFitted.
			// Mid is used to pass the segment of remaining text left off from the 
			// previous page of printing (recall that intCurrentChar was declared as 
			// static.
			int intLinesFilled;
			int intCharsFitted;
			e.Graphics.MeasureString(txtDocument.Text.Substring(_currentCharIndex), font, new SizeF(intPrintAreaWidth, intPrintAreaHeight), fmt, out intCharsFitted, out intLinesFilled);

			// Print the text to the page.
			e.Graphics.DrawString(txtDocument.Text.Substring(_currentCharIndex), font, Brushes.Black, rectPrintingArea, fmt);

			// Advance the current char to the last char printed on this page. As 
			// intCurrentChar is a static variable, its value can be used for the next
			// page to be printed. It is advanced by 1 and passed to Mid() to print the
			// next page (see above in MeasureString()).
			_currentCharIndex += intCharsFitted;

			// HasMorePages tells the printing module whether another PrintPage event should be fired.
			if (_currentCharIndex < txtDocument.Text.Length)
				e.HasMorePages = true;
		}
	}
}

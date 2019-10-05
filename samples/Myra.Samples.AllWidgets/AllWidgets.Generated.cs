/* Generated by MyraPad at 05.10.2019 15:58:02 */
using Myra.Graphics2D.UI;

#if !XENKO
using Microsoft.Xna.Framework;
#else
using Xenko.Core.Mathematics;
#endif

namespace Myra.Samples.AllWidgets
{
	partial class AllWidgets: VerticalStackPanel
	{
		private void BuildUI()
		{
			_menuItemNew = new MenuItem();
			_menuItemNew.Id = "_menuItemNew";
			_menuItemNew.Text = "&New";

			_menuItemOpen = new MenuItem();
			_menuItemOpen.Id = "_menuItemOpen";
			_menuItemOpen.Text = "&Open";

			_menuItemSave = new MenuItem();
			_menuItemSave.Id = "_menuItemSave";
			_menuItemSave.Text = "&Save";

			_menuItemSaveAs = new MenuItem();
			_menuItemSaveAs.Id = "_menuItemSaveAs";
			_menuItemSaveAs.Text = "Save &As...";

			var menuSeparator1 = new MenuSeparator();

			_menuItemQuit = new MenuItem();
			_menuItemQuit.Id = "_menuItemQuit";
			_menuItemQuit.Text = "&Quit";

			var menuItem1 = new MenuItem();
			menuItem1.Id = "";
			menuItem1.Text = "&File";
			menuItem1.Items.Add(_menuItemNew);
			menuItem1.Items.Add(_menuItemOpen);
			menuItem1.Items.Add(_menuItemSave);
			menuItem1.Items.Add(_menuItemSaveAs);
			menuItem1.Items.Add(menuSeparator1);
			menuItem1.Items.Add(_menuItemQuit);

			_menuItemCopy = new MenuItem();
			_menuItemCopy.Id = "_menuItemCopy";
			_menuItemCopy.Text = "&Copy";

			_menuItemPaste = new MenuItem();
			_menuItemPaste.Id = "_menuItemPaste";
			_menuItemPaste.Text = "&Paste";

			var menuSeparator2 = new MenuSeparator();

			_menuItemUndo = new MenuItem();
			_menuItemUndo.Id = "_menuItemUndo";
			_menuItemUndo.Text = "&Undo";

			_menuItemRedo = new MenuItem();
			_menuItemRedo.Id = "_menuItemRedo";
			_menuItemRedo.Text = "&Redo";

			var menuItem2 = new MenuItem();
			menuItem2.Id = "";
			menuItem2.Text = "&Edit";
			menuItem2.Items.Add(_menuItemCopy);
			menuItem2.Items.Add(_menuItemPaste);
			menuItem2.Items.Add(menuSeparator2);
			menuItem2.Items.Add(_menuItemUndo);
			menuItem2.Items.Add(_menuItemRedo);

			_menuItemAbout = new MenuItem();
			_menuItemAbout.Id = "_menuItemAbout";
			_menuItemAbout.Text = "&About";

			var menuItem3 = new MenuItem();
			menuItem3.Id = "";
			menuItem3.Text = "&Help";
			menuItem3.Items.Add(_menuItemAbout);

			var horizontalMenu1 = new HorizontalMenu();
			horizontalMenu1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			horizontalMenu1.Items.Add(menuItem1);
			horizontalMenu1.Items.Add(menuItem2);
			horizontalMenu1.Items.Add(menuItem3);

			var label1 = new Label();
			label1.Text = "Button:";
			label1.Id = "";

			_buttonSaveFile = new ImageTextButton();
			_buttonSaveFile.Text = "Save File";
			_buttonSaveFile.Id = "_buttonSaveFile";
			_buttonSaveFile.PaddingLeft = 8;
			_buttonSaveFile.PaddingRight = 8;
			_buttonSaveFile.GridColumn = 1;

			_textSaveFile = new TextBox();
			_textSaveFile.Text = "";
			_textSaveFile.Id = "_textSaveFile";
			_textSaveFile.GridColumn = 2;

			var label2 = new Label();
			label2.Text = "Another Button:";
			label2.Id = "";
			label2.GridRow = 1;

			_buttonOpenFile = new ImageTextButton();
			_buttonOpenFile.Text = "Open File";
			_buttonOpenFile.Id = "_buttonOpenFile";
			_buttonOpenFile.PaddingLeft = 8;
			_buttonOpenFile.PaddingRight = 8;
			_buttonOpenFile.GridColumn = 1;
			_buttonOpenFile.GridRow = 1;

			_textOpenFile = new TextBox();
			_textOpenFile.Text = "";
			_textOpenFile.Id = "_textOpenFile";
			_textOpenFile.GridColumn = 2;
			_textOpenFile.GridRow = 1;

			var label3 = new Label();
			label3.Text = "Blue Button:";
			label3.Id = "";
			label3.GridRow = 2;

			_buttonChooseFolder = new ImageTextButton("blue");
			_buttonChooseFolder.Text = "Choose Folder";
			_buttonChooseFolder.Id = "_buttonChooseFolder";
			_buttonChooseFolder.PaddingLeft = 8;
			_buttonChooseFolder.PaddingRight = 8;
			_buttonChooseFolder.GridColumn = 1;
			_buttonChooseFolder.GridRow = 2;

			_textChooseFolder = new TextBox();
			_textChooseFolder.Text = "";
			_textChooseFolder.Id = "_textChooseFolder";
			_textChooseFolder.GridColumn = 2;
			_textChooseFolder.GridRow = 2;

			_textButtonLabel = new Label();
			_textButtonLabel.Text = "Text Button:";
			_textButtonLabel.Id = "_textButtonLabel";
			_textButtonLabel.GridRow = 3;

			_buttonChooseColor = new TextButton();
			_buttonChooseColor.Text = "Choose Color";
			_buttonChooseColor.Id = "_buttonChooseColor";
			_buttonChooseColor.PaddingLeft = 8;
			_buttonChooseColor.PaddingRight = 8;
			_buttonChooseColor.GridColumn = 1;
			_buttonChooseColor.GridRow = 3;

			var label4 = new Label();
			label4.Text = "Image Button:";
			label4.Id = "";
			label4.GridRow = 4;

			_imageButton = new ImageButton();
			_imageButton.Id = "_imageButton";
			_imageButton.PaddingLeft = 8;
			_imageButton.PaddingRight = 8;
			_imageButton.GridColumn = 1;
			_imageButton.GridRow = 4;

			var checkBox1 = new CheckBox();
			checkBox1.Text = "This is checkbox";
			checkBox1.ImageWidth = 10;
			checkBox1.ImageHeight = 10;
			checkBox1.GridRow = 5;
			checkBox1.GridColumnSpan = 2;

			var label5 = new Label();
			label5.Text = "Horizontal Slider:";
			label5.Id = "";
			label5.GridRow = 6;

			var horizontalSlider1 = new HorizontalSlider();
			horizontalSlider1.GridColumn = 1;
			horizontalSlider1.GridRow = 6;
			horizontalSlider1.GridColumnSpan = 2;

			var label6 = new Label();
			label6.Text = "Combo Box:";
			label6.GridRow = 7;

			var listItem1 = new ListItem();
			listItem1.Id = "";
			listItem1.Text = "Red";
			listItem1.Color = Color.Red;

			var listItem2 = new ListItem();
			listItem2.Id = null;
			listItem2.Text = "Green";
			listItem2.Color = Color.Lime;

			var listItem3 = new ListItem();
			listItem3.Id = null;
			listItem3.Text = "Blue";
			listItem3.Color = new Color
			{
				B = 255,
				G = 128,
				R = 0,
				A = 255,
			};

			var comboBox1 = new ComboBox();
			comboBox1.Width = 200;
			comboBox1.GridColumn = 1;
			comboBox1.GridRow = 7;
			comboBox1.GridColumnSpan = 2;
			comboBox1.Items.Add(listItem1);
			comboBox1.Items.Add(listItem2);
			comboBox1.Items.Add(listItem3);

			var label7 = new Label();
			label7.Text = "Text Field:";
			label7.GridRow = 8;

			var textBox1 = new TextBox();
			textBox1.Text = "";
			textBox1.GridColumn = 1;
			textBox1.GridRow = 8;
			textBox1.GridColumnSpan = 2;

			var label8 = new Label();
			label8.Text = "Spin Button:";
			label8.GridRow = 9;

			var spinButton1 = new SpinButton();
			spinButton1.Value = 1;
			spinButton1.Width = 100;
			spinButton1.GridColumn = 1;
			spinButton1.GridRow = 9;

			var label9 = new Label();
			label9.Text = "List Box:";
			label9.GridRow = 10;

			var listItem4 = new ListItem();
			listItem4.Id = null;
			listItem4.Text = "Red";
			listItem4.Color = Color.Red;

			var listItem5 = new ListItem();
			listItem5.Id = null;
			listItem5.Text = "Green";
			listItem5.Color = Color.Lime;

			var listItem6 = new ListItem();
			listItem6.Id = null;
			listItem6.Text = "Blue";
			listItem6.Color = Color.Blue;

			var listBox1 = new ListBox();
			listBox1.Width = 200;
			listBox1.GridColumn = 1;
			listBox1.GridRow = 10;
			listBox1.GridColumnSpan = 2;
			listBox1.Items.Add(listItem4);
			listBox1.Items.Add(listItem5);
			listBox1.Items.Add(listItem6);

			var label10 = new Label();
			label10.Text = "Vertical Menu:";
			label10.GridRow = 11;

			var menuItem4 = new MenuItem();
			menuItem4.Id = "";
			menuItem4.Text = "Start New Game";

			var menuItem5 = new MenuItem();
			menuItem5.Id = "";
			menuItem5.Text = "Options";

			var menuItem6 = new MenuItem();
			menuItem6.Id = "";
			menuItem6.Text = "Quit";

			var verticalMenu1 = new VerticalMenu();
			verticalMenu1.GridColumn = 1;
			verticalMenu1.GridRow = 11;
			verticalMenu1.Items.Add(menuItem4);
			verticalMenu1.Items.Add(menuItem5);
			verticalMenu1.Items.Add(menuItem6);

			var label11 = new Label();
			label11.Text = "Tree";
			label11.GridRow = 12;

			_gridRight = new Grid();
			_gridRight.ColumnSpacing = 8;
			_gridRight.RowSpacing = 8;
			_gridRight.DefaultRowProportion = new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			};
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			_gridRight.Id = "_gridRight";
			_gridRight.Widgets.Add(label1);
			_gridRight.Widgets.Add(_buttonSaveFile);
			_gridRight.Widgets.Add(_textSaveFile);
			_gridRight.Widgets.Add(label2);
			_gridRight.Widgets.Add(_buttonOpenFile);
			_gridRight.Widgets.Add(_textOpenFile);
			_gridRight.Widgets.Add(label3);
			_gridRight.Widgets.Add(_buttonChooseFolder);
			_gridRight.Widgets.Add(_textChooseFolder);
			_gridRight.Widgets.Add(_textButtonLabel);
			_gridRight.Widgets.Add(_buttonChooseColor);
			_gridRight.Widgets.Add(label4);
			_gridRight.Widgets.Add(_imageButton);
			_gridRight.Widgets.Add(checkBox1);
			_gridRight.Widgets.Add(label5);
			_gridRight.Widgets.Add(horizontalSlider1);
			_gridRight.Widgets.Add(label6);
			_gridRight.Widgets.Add(comboBox1);
			_gridRight.Widgets.Add(label7);
			_gridRight.Widgets.Add(textBox1);
			_gridRight.Widgets.Add(label8);
			_gridRight.Widgets.Add(spinButton1);
			_gridRight.Widgets.Add(label9);
			_gridRight.Widgets.Add(listBox1);
			_gridRight.Widgets.Add(label10);
			_gridRight.Widgets.Add(verticalMenu1);
			_gridRight.Widgets.Add(label11);

			var scrollViewer1 = new ScrollViewer();
			scrollViewer1.Content = _gridRight;

			var label12 = new Label();
			label12.Text = "Vertical Slider:";

			var verticalSlider1 = new VerticalSlider();
			verticalSlider1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			verticalSlider1.GridRow = 1;

			var grid1 = new Grid();
			grid1.RowSpacing = 8;
			grid1.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid1.Widgets.Add(label12);
			grid1.Widgets.Add(verticalSlider1);

			var label13 = new Label();
			label13.Text = "Progress Bars:";

			_horizontalProgressBar = new HorizontalProgressBar();
			_horizontalProgressBar.Id = "_horizontalProgressBar";
			_horizontalProgressBar.GridRow = 1;

			_verticalProgressBar = new VerticalProgressBar();
			_verticalProgressBar.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_verticalProgressBar.Id = "_verticalProgressBar";
			_verticalProgressBar.GridRow = 2;

			var grid2 = new Grid();
			grid2.RowSpacing = 8;
			grid2.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid2.Widgets.Add(label13);
			grid2.Widgets.Add(_horizontalProgressBar);
			grid2.Widgets.Add(_verticalProgressBar);

			var verticalSplitPane1 = new VerticalSplitPane();
			verticalSplitPane1.Widgets.Add(grid1);
			verticalSplitPane1.Widgets.Add(grid2);

			var horizontalSplitPane1 = new HorizontalSplitPane();
			horizontalSplitPane1.Widgets.Add(scrollViewer1);
			horizontalSplitPane1.Widgets.Add(verticalSplitPane1);

			
			Spacing = 8;
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			Widgets.Add(horizontalMenu1);
			Widgets.Add(horizontalSplitPane1);
		}

		
		public MenuItem _menuItemNew;
		public MenuItem _menuItemOpen;
		public MenuItem _menuItemSave;
		public MenuItem _menuItemSaveAs;
		public MenuItem _menuItemQuit;
		public MenuItem _menuItemCopy;
		public MenuItem _menuItemPaste;
		public MenuItem _menuItemUndo;
		public MenuItem _menuItemRedo;
		public MenuItem _menuItemAbout;
		public ImageTextButton _buttonSaveFile;
		public TextBox _textSaveFile;
		public ImageTextButton _buttonOpenFile;
		public TextBox _textOpenFile;
		public ImageTextButton _buttonChooseFolder;
		public TextBox _textChooseFolder;
		public Label _textButtonLabel;
		public TextButton _buttonChooseColor;
		public ImageButton _imageButton;
		public Grid _gridRight;
		public HorizontalProgressBar _horizontalProgressBar;
		public VerticalProgressBar _verticalProgressBar;
	}
}